using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ParfumeOnlineShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Parfume parfume,int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItem.SingleOrDefault(s => s.Parfume.ParfumeId == parfume.ParfumeId
                                   && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Parfume = parfume,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItem.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Parfume parfume)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItem.SingleOrDefault(s=>s.Parfume.ParfumeId == parfume.ParfumeId
                && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem !=null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItem.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _appDbContext.ShoppingCartItem.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Parfume)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItem.Where(cart => cart.ShoppingCartId == ShoppingCartId);
            _appDbContext.ShoppingCartItem.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItem.Where(c => c.ShoppingCartId == ShoppingCartId)
                          .Select(c => c.Parfume.Price * c.Amount).Sum();

            return total;
        }
    }
}
