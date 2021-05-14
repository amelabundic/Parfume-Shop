using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfumeOnlineShop.Migrations
{
    public partial class AddData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Parfume",
                columns: table => new
                {
                    ParfumeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsParfumeOfTheMonth = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parfume", x => x.ParfumeId);
                    table.ForeignKey(
                        name: "FK_Parfume_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Man parfumes", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Women parfumes", null });

            migrationBuilder.InsertData(
                table: "Parfume",
                columns: new[] { "ParfumeId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsParfumeOfTheMonth", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "\\Images\\MenuThumbnail\\MCalvinKlein.jpg", "\\Images\\Menu\\MCalvinKlein.jpg", true, false, "Calvin Kleins cutting edge minimalism and sexy style captured in a classic and sophisticated fragrance. The essence of the modern man captured in a blend of crisp freshness, exotic spices and fresh woods.", "Calvin Klein man", 187.95m, "Fresh and natural scents" },
                    { 2, 1, "\\Images\\MenuThumbnail\\MDolceGabbana.jpg", "\\Images\\Menu\\MDolceGabbana.jpg", true, false, " A fragrance that is both classic and modern, vibrant and engaging. A spicy, oriental perfume, developed on the harmony of tobacco with refined boisé notes.", "Dolce & Gabbana man", 189.95m, "The One for Men is a concentrate of elegance and sensuality." },
                    { 3, 1, "\\Images\\MenuThumbnail\\MValentino.jpg", "\\Images\\Menu\\MValentino.jpg", true, false, "Memories of the night become another new beginning.Imaginations of our past inspire dreams of tomorrow.Bathed in yellow light,the eternal city stirs.", "Valentino man", 155.95m, "Eau de Toilette for him" },
                    { 4, 1, "\\Images\\MenuThumbnail\\MVersace.jpg", "\\Images\\Menu\\MVersace.jpg", true, false, "The seduction of a desert sunset; a warm breeze in the air giving a feeling of well being. A sensual heady aroma, almost aphrodisiacal.", "Versace man", 139.95m, "Oriental Scent for Him" },
                    { 5, 1, "\\Images\\MenuThumbnail\\MVersace1.jpg", "\\Images\\Menu\\MVersace1.jpg", true, false, "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.", "Versace man1", 170.95m, "A sophisticated masculine perfume." },
                    { 6, 2, "\\Images\\MenuThumbnail\\ZChanel.jpg", "\\Images\\Menu\\ZChanel.jpg", false, false, "The essence of a bold, free woman. An airy, oriental-fresh fragrance, housed in a refillable spray.", "Chanel women", 155.95m, " An iconic bottle, perfect for travel. " },
                    { 7, 2, "\\Images\\MenuThumbnail\\ZChanel1.jpg", "\\Images\\Menu\\ZChanel1.jpg", true, true, "A feminine oriental fragrance with a voluptuous yet surprisingly fresh composition. A daring fragrance housed in an iconic bottle hand-sealed with a baudruche film. ", "Chanel women 1", 127.95m, "The essence of a bold, free woman." },
                    { 8, 2, "\\Images\\MenuThumbnail\\ZScandal.jpg", "\\Images\\Menu\\ZScandal.jpg", true, false, "Scandal is a new kind of fragrance for women: the elegant aura that it leaves in her wake is sullied by the Pigalle spirit beloved by Jean Paul Gaultier. Even Madam Minister is tempted by this scent of Scandal.", "Scandal", 150.95m, "With its sensuous heart of patchouli." },
                    { 9, 2, "\\Images\\MenuThumbnail\\ZSexySecret.jpg", "\\Images\\Menu\\ZSexySecret.jpg", true, false, "Sexy Secret is an innocent yet sensual and sexy potion that makes a bold entrance and then dries down to soft, powdery femininity.", "Sexy Secret", 180.95m, "Soft, feminine and bursting with Roses" },
                    { 10, 2, "\\Images\\MenuThumbnail\\ZSkinn.jpg", "\\Images\\Menu\\ZSkinn.jpg", false, false, "The fragrance itself is a hymn of joyful living and transports you to a world where time is suspended and women have the courage to make themselves a priority.", "Skinn", 1450.95m, "The essence of a bold, free woman." },
                    { 11, 2, "\\Images\\MenuThumbnail\\ZValentino.jpg", "\\Images\\Menu\\ZValentino.jpg", true, true, "Born in Roma Yellow Dream is inspired by the iconic golden sunrise of Rome, known as the Golden hour.In Roma,daylight hits the streets.", "Valentino Women", 130.95m, "One of life's simple pleasures." },
                    { 12, 2, "\\Images\\MenuThumbnail\\ZVersace.jpg", "\\Images\\Menu\\ZVersace.jpg", false, false, "Eros in a perfume. An alchemy of tempting, bright and feminine notes. A refined accord of lemon and jasmine, exalted by sensual and smooth woods.", "Versace women", 164.95m, "Attraction, desire, passion." },
                    { 13, 2, "\\Images\\MenuThumbnail\\ZZara.jpg", "\\Images\\Menu\\ZZara.jpg", true, true, "The sensuality of ambery woods the sunny and vibrant character of palo santo wood the refined presence of musk.", "Zara", 100.95m, "The fragrance unveils like a burst of light." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parfume_CategoryId",
                table: "Parfume",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parfume");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
