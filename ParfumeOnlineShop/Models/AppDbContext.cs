using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeOnlineShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Parfume> Parfume { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Man parfumes" },
                new Category { CategoryId = 2, CategoryName = "Women parfumes" }
                );

            modelBuilder.Entity<Parfume>().HasData(
           
                new Parfume { ParfumeId = 1, Name = "Calvin Klein man", Price = 187.95M, ShortDescription = "Fresh and natural scents", LongDescription = "Calvin Kleins cutting edge minimalism and sexy style captured in a classic and sophisticated fragrance. The essence of the modern man captured in a blend of crisp freshness, exotic spices and fresh woods.", CategoryId = 1, ImageUrl = @"\Images\Menu\MCalvinKlein.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\MCalvinKlein.jpg" },
                new Parfume { ParfumeId = 2, Name = "Dolce & Gabbana man", Price = 189.95M, ShortDescription = "The One for Men is a concentrate of elegance and sensuality.", LongDescription = " A fragrance that is both classic and modern, vibrant and engaging. A spicy, oriental perfume, developed on the harmony of tobacco with refined boisé notes.", CategoryId = 1, ImageUrl = @"\Images\Menu\MDolceGabbana.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\MDolceGabbana.jpg" },
                new Parfume { ParfumeId = 3, Name = "Valentino man", Price = 155.95M, ShortDescription = "Eau de Toilette for him", LongDescription = "Memories of the night become another new beginning.Imaginations of our past inspire dreams of tomorrow.Bathed in yellow light,the eternal city stirs.", CategoryId = 1, ImageUrl = @"\Images\Menu\MValentino.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\MValentino.jpg" },
                new Parfume { ParfumeId = 4, Name = "Versace man", Price = 139.95M, ShortDescription = "Oriental Scent for Him", LongDescription = "The seduction of a desert sunset; a warm breeze in the air giving a feeling of well being. A sensual heady aroma, almost aphrodisiacal.", CategoryId = 1, ImageUrl = @"\Images\Menu\MVersace.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\MVersace.jpg" },
                new Parfume { ParfumeId = 5, Name = "Versace man1", Price = 170.95M, ShortDescription = "A sophisticated masculine perfume.", LongDescription = "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.", CategoryId = 1, ImageUrl = @"\Images\Menu\MVersace1.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\MVersace1.jpg" },
                new Parfume { ParfumeId = 6, Name = "Chanel women", Price = 155.95M, ShortDescription = " An iconic bottle, perfect for travel. ", LongDescription = "The essence of a bold, free woman. An airy, oriental-fresh fragrance, housed in a refillable spray.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZChanel.jpg", InStock = false, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZChanel.jpg" },
                new Parfume { ParfumeId = 7, Name = "Chanel women 1", Price = 127.95M, ShortDescription = "The essence of a bold, free woman.", LongDescription = "A feminine oriental fragrance with a voluptuous yet surprisingly fresh composition. A daring fragrance housed in an iconic bottle hand-sealed with a baudruche film. ", CategoryId = 2, ImageUrl = @"\Images\Menu\ZChanel1.jpg", InStock = true, IsParfumeOfTheMonth = true, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZChanel1.jpg" },
                new Parfume { ParfumeId = 8, Name = "Scandal", Price = 150.95M, ShortDescription = "With its sensuous heart of patchouli.", LongDescription = "Scandal is a new kind of fragrance for women: the elegant aura that it leaves in her wake is sullied by the Pigalle spirit beloved by Jean Paul Gaultier. Even Madam Minister is tempted by this scent of Scandal.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZScandal.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZScandal.jpg" },
                new Parfume { ParfumeId = 9, Name = "Sexy Secret", Price = 180.95M, ShortDescription = "Soft, feminine and bursting with Roses", LongDescription = "Sexy Secret is an innocent yet sensual and sexy potion that makes a bold entrance and then dries down to soft, powdery femininity.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZSexySecret.jpg", InStock = true, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZSexySecret.jpg" },
                new Parfume { ParfumeId = 10, Name = "Skinn", Price = 1450.95M, ShortDescription = "The essence of a bold, free woman.", LongDescription = "The fragrance itself is a hymn of joyful living and transports you to a world where time is suspended and women have the courage to make themselves a priority.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZSkinn.jpg", InStock = false, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZSkinn.jpg" },
                new Parfume { ParfumeId = 11, Name = "Valentino Women", Price = 130.95M, ShortDescription = "One of life's simple pleasures.", LongDescription = "Born in Roma Yellow Dream is inspired by the iconic golden sunrise of Rome, known as the Golden hour.In Roma,daylight hits the streets.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZValentino.jpg", InStock = true, IsParfumeOfTheMonth = true, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZValentino.jpg" },
                new Parfume { ParfumeId = 12, Name = "Versace women", Price = 164.95M, ShortDescription = "Attraction, desire, passion.", LongDescription = "Eros in a perfume. An alchemy of tempting, bright and feminine notes. A refined accord of lemon and jasmine, exalted by sensual and smooth woods.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZVersace.jpg", InStock = false, IsParfumeOfTheMonth = false, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZVersace.jpg" },
                new Parfume { ParfumeId = 13, Name = "Zara", Price = 100.95M, ShortDescription = "The fragrance unveils like a burst of light.", LongDescription = "The sensuality of ambery woods the sunny and vibrant character of palo santo wood the refined presence of musk.", CategoryId = 2, ImageUrl = @"\Images\Menu\ZZara.jpg", InStock = true, IsParfumeOfTheMonth = true, ImageThumbnailUrl = @"\Images\MenuThumbnail\ZZara.jpg" }

                );
        }
    }
}
