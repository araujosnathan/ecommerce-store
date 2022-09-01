using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.API.Migrations
{
    public partial class AddProductDataTableOnDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    img_url = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category", "description", "img_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 1", 7.77m },
                    { 2L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 2", 7.77m },
                    { 3L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 3", 7.77m },
                    { 4L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 4", 7.77m },
                    { 5L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 5", 7.77m },
                    { 6L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 6", 7.77m },
                    { 7L, "Esporte", "Alta qualidade", "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE", "Blusa Nike 7", 7.77m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
