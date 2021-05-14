using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.ViewModel;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
    
        private readonly IParfumeRepository _parfumeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IParfumeRepository parfumeRepository, ShoppingCart shoppingCart)
        {
            _parfumeRepository = parfumeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            //test data
            /*test*/
            //ShoppingCartItem item = new ShoppingCartItem();
            //item.Parfume = _parfumeRepository.Parfumes.FirstOrDefault(p => p.ParfumeId == 1);
            //item.Amount = 2;
            //items.Add(item);
            /*end test*/
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int parfumeId)
        {
            var selectedParfume = _parfumeRepository.Parfumes.FirstOrDefault(p=>p.ParfumeId == parfumeId);

            if (selectedParfume !=null)
            {
                _shoppingCart.AddToCart(selectedParfume, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int parfumeId)
        {
            var selectedParfume = _parfumeRepository.Parfumes.FirstOrDefault(p => p.ParfumeId == parfumeId);

            if (selectedParfume !=null)
            {
                _shoppingCart.RemoveFromCart(selectedParfume);
            }
            return RedirectToAction("Index");
        }
    }
}