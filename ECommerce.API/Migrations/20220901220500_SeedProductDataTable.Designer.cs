﻿// <auto-generated />
using ECommerce.API.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.API.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220901220500_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ECommerce.API.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("img_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 1",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 2L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 2",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 3L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 3",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 4L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 4",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 5L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 5",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 6L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 6",
                            Price = 7.77m
                        },
                        new
                        {
                            Id = 7L,
                            Category = "Esporte",
                            Description = "Alta qualidade",
                            ImageURL = "https://www.aboutyou.pt/p/nike-sportswear/sweatshirt-6663373?utm_content=ppc&utm_source=google&utm_medium=cpc&utm_campaign=PLA_PT_M_Brand_NK_CSS_ADF&gclid=CjwKCAjwsMGYBhAEEiwAGUXJaWen2hJbLzh1WGipqQTCYPRZOv0i1AUGB-B98v3JuxqKk3qb_zLnYhoCzlEQAvD_BwE",
                            Name = "Blusa Nike 7",
                            Price = 7.77m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
