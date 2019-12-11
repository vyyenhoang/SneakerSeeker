using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Data
{
    public class ApplicationDbContext : IdentityDbContext<SneakerSeekerUser, StoreRole, String>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SneakerSeeker3.Models.Product> Product { get; set; }
        public DbSet<SneakerSeeker3.Models.Category> Category { get; set; }
        public DbSet<SneakerSeeker3.Models.Supplier> Supplier { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemColor> ItemColor { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemSize> ItemSize { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemReview> ItemReview { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
            new Models.Product() { ProductId = 1, SKU = "0001A", ProductName = "Nike Red Sneaker - Women", ProductDescription = "The lightest sneaker for daily life", CategoryId = 2, SupplierId = 1, ItemColorId = 1, UnitPrice = 50, ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details" },
            new Models.Product() { ProductId = 2, SKU = "0002A", ProductName = "Nike Black Nike Air Force 1 Low - Men", ProductDescription = "The classic Black Air Force 1 mixed with silver color", CategoryId = 6, SupplierId = 1, ItemColorId = 5, UnitPrice = 150, ProductURL = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oplkqwyf7nwnj98f8agj/air-force-1-07-triple-black-mens-shoe-JkTGzADv.jpg" },
            new Models.Product() { ProductId = 3, SKU = "0003A", ProductName = "Nike Air Jordan - Men", ProductDescription = "The most modren on in Air Jordan Collection ", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 120, ProductURL = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/z7i1be9xlxbbqwubh5yi/air-jordan-1-mid-shoe-VzFBKF.jpg" },
            new Models.Product() { ProductId = 4, SKU = "0004A", ProductName = "Nike Sb Suede Low-top Sneaker - Men", ProductDescription = "Limited editin of Sb Suede Low-top", CategoryId = 4, SupplierId = 1, ItemColorId = 2, UnitPrice = 200, ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Zoom-Stefan-Janoski-Blue-%26-Sail-Suede-Shoes-_198814-0005-front.jpg" },
            new Models.Product() { ProductId = 5, SKU = "0005A", ProductName = "Nike Gray Sneaker 2018 - Women", ProductDescription = "The regular edtiton of women 2018", CategoryId = 2, SupplierId = 1, ItemColorId = 2, UnitPrice = 70, ProductURL = "https://cdn.shopify.com/s/files/1/1512/2122/products/017_Mens_Mihara_Multi_Color_Canvas_Original_Sole_Sneaker-2_copy_1024x.jpg?v=1571772687" },
            new Models.Product() { ProductId = 6, SKU = "0006A", ProductName = "Adidas Yeezy Boost 350 Shoes - Men", ProductDescription = "Last collection of Adidas 2019", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 85, ProductURL = "https://images.journeys.com/images/products/1_224909_ZM_BLUE_ALT1.JPG" },
            new Models.Product() { ProductId = 7, SKU = "0007A", ProductName = "Adidas Originals NMD R1 sneakers - Men", ProductDescription = "This adidas Originals NMD R1 merges the style you need", CategoryId = 2, SupplierId = 2, ItemColorId = 4, UnitPrice = 135, ProductURL = "https://cdn-images.farfetch-contents.com/14/26/62/34/14266234_20084985_600.jpg" },
            new Models.Product() { ProductId = 8, SKU = "0008A", ProductName = "Adidas Yeezy Boost 350 V2 shoes - women", ProductDescription = "One of the most popular Yeezy shoes ever made", CategoryId = 5, SupplierId = 2, ItemColorId = 4, UnitPrice = 180, ProductURL = "https://shop.r10s.jp/noel-ange/cabinet/shoes/adidas2/adi-d96635-al-a.jpg" },
            new Models.Product() { ProductId = 9, SKU = "0009A", ProductName = "Adidas LITE RACER RBN running shoes - Men", ProductDescription = "These shoes have a lightweight textile", CategoryId = 5, SupplierId = 2, ItemColorId = 1, UnitPrice = 150, ProductURL = "https://assets.adidas.com/images/w_600,f_auto,q_auto:sensitive,fl_lossy/04fd20874e024a519fe3a99901315e1a_9366/Lite_Racer_RBN_Shoes_Black_F36783_01_standard.jpg" },
            new Models.Product() { ProductId = 10, SKU = "0010A", ProductName = "Adidas originals superstar shoes - women", ProductDescription = "This is the most faithful reproduction of the shell-toe shoes", CategoryId = 3, SupplierId = 2, ItemColorId = 4, UnitPrice = 200, ProductURL = "https://images.bloomingdalesassets.com/is/image/BLM/products/7/optimized/9942107_fpx.tif?op_sharpen=1&wid=700&fit=fit,1&$filtersm$" },
            new Models.Product() { ProductId = 11, SKU = "0011A", ProductName = "Fila Disruptor II Premium - Women", ProductDescription = "FILA’s most popular women’s silhouette", CategoryId = 2, SupplierId = 4, ItemColorId = 4, UnitPrice = 90, ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/FILA-Disruptor-Multicolor-%26-White-Shoes-_311646-front-US.jpg" },
            new Models.Product() { ProductId = 12, SKU = "0012A", ProductName = "Fila DISRUPTOR M LOW - women", ProductDescription = "90's are back. This shoe has got a narrow fit", CategoryId = 2, SupplierId = 4, ItemColorId = 6, UnitPrice = 70, ProductURL = "https://photos.queens.cz/queens/2019-03/large/fila-disruptor-m-low-wmn-89669_1.jpg" },
            new Models.Product() { ProductId = 13, SKU = "0013A", ProductName = "Vans Era - Men", ProductDescription = "The Era, Vans classic low top lace-up skate shoe", CategoryId = 1, SupplierId = 5, ItemColorId = 1, UnitPrice = 85, ProductURL = "https://imagescdn.simons.ca/images/8728-319317-60-A1_2/era-bright-red-sneakers-men.jpg?__=3" },
            new Models.Product() { ProductId = 14, SKU = "0014A", ProductName = "Vans Authentic - Women", ProductDescription = "The Authentic, Vans original and now iconic style, is a simple low top", CategoryId = 1, SupplierId = 5, ItemColorId = 2, UnitPrice = 70, ProductURL = "http://www.chamberschaos.com/wp-content/uploads/2018/05/vans-slip-on-pro-allen-navy-white-skate-shoes-blue-mens-skate-shoes.jpg" },
            new Models.Product() { ProductId = 15, SKU = "0015A", ProductName = "Adidas Yeezy Boost 350 V2 - women", ProductDescription = "This is one of three regional exclusive colorways that released in March 2019", CategoryId = 2, SupplierId = 2, ItemColorId = 8, UnitPrice = 150, ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/adidas-Xplorer-Ice-Pink-Shoes-_311952.jpg" },
            new Models.Product() { ProductId = 16, SKU = "0016A", ProductName = "Adidas EQT Basketball ADV Unisex Running Soes - Men", ProductDescription = "The first sneaker in the EQT line designed with the baller in mind", CategoryId = 5, SupplierId = 2, ItemColorId = 2, UnitPrice = 140, ProductURL = "https://media.endclothing.com/media/catalog/product/2/3/23-03-2018_adidas_eqtbaskadvw_ashblue_white_ac7353_mg_1.jpg" },
            new Models.Product() { ProductId = 17, SKU = "0017A", ProductName = "Nike Jordan 13 Retro Alternate - Men", ProductDescription = "The Jordan Retro 13 is a retro version of the shoe MJ wore as he captured his sixth championship", CategoryId = 5, SupplierId = 1, ItemColorId = 4, UnitPrice = 100, ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Nyjah-Free-White-Skate-Shoes-_290339.jpg" },
            new Models.Product() { ProductId = 18, SKU = "0018A", ProductName = "Nike Air Max 1 - women", ProductDescription = "Keep your outfit cookin with a pair of these Nike Air Max 1", CategoryId = 2, SupplierId = 1, ItemColorId = 7, UnitPrice = 80, ProductURL = "https://c.static-nike.com/a/images/t_prod_ss/w_960,c_limit,f_auto/ikvlpfgtitt6mybtdcug/nike-air-max-1-premium-dark-curry-release-date.jpg" },
            new Models.Product() { ProductId = 19, SKU = "0019A", ProductName = "Puma Clyde Core Lace - Women", ProductDescription = "Stay fly. Stay fresh with most new style of 2019", CategoryId = 1, SupplierId = 3, ItemColorId = 4, UnitPrice = 60, ProductURL = "https://dsw.scene7.com/is/image/DSWShoes/447627_100_ss_01?$colpg$" },
            new Models.Product() { ProductId = 20, SKU = "0020A", ProductName = "Puma LQDCELL Optic Sci-Fi Training Shoes - women", ProductDescription = "In a fast-paced world, your senses need to be sharp", CategoryId = 5, SupplierId = 3, ItemColorId = 3, UnitPrice = 40, ProductURL = "https://i.pinimg.com/originals/50/7f/bd/507fbd1acb876b460384daeb03246540.jpg" });


            modelBuilder.Entity<Category>().HasData(
            new Models.Category() { CategoryId = 1, CategoryName = "Sneakers", Description = "The best sneakers are here", Active = true },
            new Models.Category() { CategoryId = 2, CategoryName = "Running", Description = "Enjoy running by our shoes", Active = true },
            new Models.Category() { CategoryId = 3, CategoryName = "Casual", Description = "The perfect fit for your style", Active = true },
            new Models.Category() { CategoryId = 4, CategoryName = "Basketball", Description = "Enjoy playing basketball by our best shoes", Active = true },
            new Models.Category() { CategoryId = 5, CategoryName = "Formal", Description = "For professional life style", Active = true },
            new Models.Category() { CategoryId = 6, CategoryName = "Football", Description = "For every smoth football game", Active = true });

            modelBuilder.Entity<Supplier>().HasData(
            new Models.Supplier() { SupplierId = 1, CompanyName = "Nike", URL = "https://i.pinimg.com/originals/4d/96/2d/4d962dee72fa76f023d411e20d30690c.jpg" },
            new Models.Supplier() { SupplierId = 2, CompanyName = "Adidas", URL = "https://seeklogo.com/images/A/adidas-logo-107B082DA0-seeklogo.com.png" },
            new Models.Supplier() { SupplierId = 3, CompanyName = "Puma", URL = "https://seeklogo.com/images/P/Puma-logo-C1C1A4A6DF-seeklogo.com.png" },
            new Models.Supplier() { SupplierId = 4, CompanyName = "Fila", URL = "https://seeklogo.com/images/F/fila-logo-C3B98A98FB-seeklogo.com.png" },
            new Models.Supplier() { SupplierId = 5, CompanyName = "Vans", URL = "http://logosvg.com/wp-content/uploads/2017/02/Vans_logo.png" });


            modelBuilder.Entity<ItemColor>().HasData(
            new Models.ItemColor() { ItemColorId = 1, Color = "Red" },
            new Models.ItemColor() { ItemColorId = 2, Color = "Blue" },
            new Models.ItemColor() { ItemColorId = 3, Color = "Gray" },
            new Models.ItemColor() { ItemColorId = 4, Color = "White" },
            new Models.ItemColor() { ItemColorId = 5, Color = "Black" },
            new Models.ItemColor() { ItemColorId = 6, Color = "Silver" },
            new Models.ItemColor() { ItemColorId = 7, Color = "Curry" },
            new Models.ItemColor() { ItemColorId = 8, Color = "Pink" });


            modelBuilder.Entity<ItemSize>().HasData(
            new Models.ItemSize() { ItemSizeId = 1, Size = "5" },
            new Models.ItemSize() { ItemSizeId = 2, Size = "6" },
            new Models.ItemSize() { ItemSizeId = 3, Size = "7" },
            new Models.ItemSize() { ItemSizeId = 4, Size = "8" },
            new Models.ItemSize() { ItemSizeId = 5, Size = "9" },
            new Models.ItemSize() { ItemSizeId = 6, Size = "10" });

        }

        public DbSet<SneakerSeeker3.Models.Cart> Cart { get; set; }
        public DbSet<SneakerSeeker3.Models.Order> Order { get; set; }
        public DbSet<SneakerSeeker3.Models.OrderDetail> OrderDetail { get; set; }
    }
}