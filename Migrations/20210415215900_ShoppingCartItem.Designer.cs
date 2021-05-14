﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210415215900_ShoppingCartItem")]
    partial class ShoppingCartItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParfumeOnlineShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Man parfumes"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Women parfumes"
                        });
                });

            modelBuilder.Entity("ParfumeOnlineShop.Models.Parfume", b =>
                {
                    b.Property<int>("ParfumeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsParfumeOfTheMonth");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("ParfumeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Parfume");

                    b.HasData(
                        new
                        {
                            ParfumeId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\MCalvinKlein.jpg",
                            ImageUrl = "\\Images\\Menu\\MCalvinKlein.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "Calvin Kleins cutting edge minimalism and sexy style captured in a classic and sophisticated fragrance. The essence of the modern man captured in a blend of crisp freshness, exotic spices and fresh woods.",
                            Name = "Calvin Klein man",
                            Price = 187.95m,
                            ShortDescription = "Fresh and natural scents"
                        },
                        new
                        {
                            ParfumeId = 2,
                            CategoryId = 1,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\MDolceGabbana.jpg",
                            ImageUrl = "\\Images\\Menu\\MDolceGabbana.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = " A fragrance that is both classic and modern, vibrant and engaging. A spicy, oriental perfume, developed on the harmony of tobacco with refined boisé notes.",
                            Name = "Dolce & Gabbana man",
                            Price = 189.95m,
                            ShortDescription = "The One for Men is a concentrate of elegance and sensuality."
                        },
                        new
                        {
                            ParfumeId = 3,
                            CategoryId = 1,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\MValentino.jpg",
                            ImageUrl = "\\Images\\Menu\\MValentino.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "Memories of the night become another new beginning.Imaginations of our past inspire dreams of tomorrow.Bathed in yellow light,the eternal city stirs.",
                            Name = "Valentino man",
                            Price = 155.95m,
                            ShortDescription = "Eau de Toilette for him"
                        },
                        new
                        {
                            ParfumeId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\MVersace.jpg",
                            ImageUrl = "\\Images\\Menu\\MVersace.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "The seduction of a desert sunset; a warm breeze in the air giving a feeling of well being. A sensual heady aroma, almost aphrodisiacal.",
                            Name = "Versace man",
                            Price = 139.95m,
                            ShortDescription = "Oriental Scent for Him"
                        },
                        new
                        {
                            ParfumeId = 5,
                            CategoryId = 1,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\MVersace1.jpg",
                            ImageUrl = "\\Images\\Menu\\MVersace1.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.",
                            Name = "Versace man1",
                            Price = 170.95m,
                            ShortDescription = "A sophisticated masculine perfume."
                        },
                        new
                        {
                            ParfumeId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZChanel.jpg",
                            ImageUrl = "\\Images\\Menu\\ZChanel.jpg",
                            InStock = false,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "The essence of a bold, free woman. An airy, oriental-fresh fragrance, housed in a refillable spray.",
                            Name = "Chanel women",
                            Price = 155.95m,
                            ShortDescription = " An iconic bottle, perfect for travel. "
                        },
                        new
                        {
                            ParfumeId = 7,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZChanel1.jpg",
                            ImageUrl = "\\Images\\Menu\\ZChanel1.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = true,
                            LongDescription = "A feminine oriental fragrance with a voluptuous yet surprisingly fresh composition. A daring fragrance housed in an iconic bottle hand-sealed with a baudruche film. ",
                            Name = "Chanel women 1",
                            Price = 127.95m,
                            ShortDescription = "The essence of a bold, free woman."
                        },
                        new
                        {
                            ParfumeId = 8,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZScandal.jpg",
                            ImageUrl = "\\Images\\Menu\\ZScandal.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "Scandal is a new kind of fragrance for women: the elegant aura that it leaves in her wake is sullied by the Pigalle spirit beloved by Jean Paul Gaultier. Even Madam Minister is tempted by this scent of Scandal.",
                            Name = "Scandal",
                            Price = 150.95m,
                            ShortDescription = "With its sensuous heart of patchouli."
                        },
                        new
                        {
                            ParfumeId = 9,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZSexySecret.jpg",
                            ImageUrl = "\\Images\\Menu\\ZSexySecret.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "Sexy Secret is an innocent yet sensual and sexy potion that makes a bold entrance and then dries down to soft, powdery femininity.",
                            Name = "Sexy Secret",
                            Price = 180.95m,
                            ShortDescription = "Soft, feminine and bursting with Roses"
                        },
                        new
                        {
                            ParfumeId = 10,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZSkinn.jpg",
                            ImageUrl = "\\Images\\Menu\\ZSkinn.jpg",
                            InStock = false,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "The fragrance itself is a hymn of joyful living and transports you to a world where time is suspended and women have the courage to make themselves a priority.",
                            Name = "Skinn",
                            Price = 1450.95m,
                            ShortDescription = "The essence of a bold, free woman."
                        },
                        new
                        {
                            ParfumeId = 11,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZValentino.jpg",
                            ImageUrl = "\\Images\\Menu\\ZValentino.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = true,
                            LongDescription = "Born in Roma Yellow Dream is inspired by the iconic golden sunrise of Rome, known as the Golden hour.In Roma,daylight hits the streets.",
                            Name = "Valentino Women",
                            Price = 130.95m,
                            ShortDescription = "One of life's simple pleasures."
                        },
                        new
                        {
                            ParfumeId = 12,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZVersace.jpg",
                            ImageUrl = "\\Images\\Menu\\ZVersace.jpg",
                            InStock = false,
                            IsParfumeOfTheMonth = false,
                            LongDescription = "Eros in a perfume. An alchemy of tempting, bright and feminine notes. A refined accord of lemon and jasmine, exalted by sensual and smooth woods.",
                            Name = "Versace women",
                            Price = 164.95m,
                            ShortDescription = "Attraction, desire, passion."
                        },
                        new
                        {
                            ParfumeId = 13,
                            CategoryId = 2,
                            ImageThumbnailUrl = "\\Images\\MenuThumbnail\\ZZara.jpg",
                            ImageUrl = "\\Images\\Menu\\ZZara.jpg",
                            InStock = true,
                            IsParfumeOfTheMonth = true,
                            LongDescription = "The sensuality of ambery woods the sunny and vibrant character of palo santo wood the refined presence of musk.",
                            Name = "Zara",
                            Price = 100.95m,
                            ShortDescription = "The fragrance unveils like a burst of light."
                        });
                });

            modelBuilder.Entity("ParfumeOnlineShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("ParfumeId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ParfumeId");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("ParfumeOnlineShop.Models.Parfume", b =>
                {
                    b.HasOne("ParfumeOnlineShop.Models.Category", "Category")
                        .WithMany("Parfumes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ParfumeOnlineShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ParfumeOnlineShop.Models.Parfume", "Parfume")
                        .WithMany()
                        .HasForeignKey("ParfumeId");
                });
#pragma warning restore 612, 618
        }
    }
}
