using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Blusa Nike 1",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Blusa Nike 2",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Blusa Nike 3",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Blusa Nike 4",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Blusa Nike 5",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Blusa Nike 6",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Blusa Nike 7",
                Price = new Decimal(7.77),
                Description = "Alta qualidade",
                Category = "Esporte",
                ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE"
            });

        }

    }

}
