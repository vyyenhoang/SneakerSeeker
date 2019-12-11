﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakerSeeker3.Data;

namespace SneakerSeeker3.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191211011535_UpdateCart1")]
    partial class UpdateCart1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ImageURL");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new { CategoryId = 1, Active = true, CategoryName = "Sneakers", Description = "Sneakers for Women" },
                        new { CategoryId = 2, Active = true, CategoryName = "Running", Description = "Running for Women" },
                        new { CategoryId = 3, Active = true, CategoryName = "Casual", Description = "Casual for Wome" },
                        new { CategoryId = 4, Active = true, CategoryName = "Sneakers", Description = "Sneakers for Men" },
                        new { CategoryId = 5, Active = true, CategoryName = "Running", Description = "Running shoes for Men" },
                        new { CategoryId = 6, Active = true, CategoryName = "Casual", Description = "Casual shoes for Men" }
                    );
                });

            modelBuilder.Entity("SneakerSeeker3.Models.ItemColor", b =>
                {
                    b.Property<int>("ItemColorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired();

                    b.HasKey("ItemColorId");

                    b.ToTable("ItemColor");

                    b.HasData(
                        new { ItemColorId = 1, Color = "Red" },
                        new { ItemColorId = 2, Color = "Blue" },
                        new { ItemColorId = 3, Color = "Gray" },
                        new { ItemColorId = 4, Color = "White" },
                        new { ItemColorId = 5, Color = "Black" },
                        new { ItemColorId = 6, Color = "Silver" },
                        new { ItemColorId = 7, Color = "Curry" },
                        new { ItemColorId = 8, Color = "Pink" }
                    );
                });

            modelBuilder.Entity("SneakerSeeker3.Models.ItemReview", b =>
                {
                    b.Property<int>("ItemReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Rate");

                    b.HasKey("ItemReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("ItemReview");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.ItemSize", b =>
                {
                    b.Property<int>("ItemSizeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Size")
                        .IsRequired();

                    b.HasKey("ItemSizeId");

                    b.ToTable("ItemSize");

                    b.HasData(
                        new { ItemSizeId = 1, Size = "5" },
                        new { ItemSizeId = 2, Size = "6" },
                        new { ItemSizeId = 3, Size = "7" },
                        new { ItemSizeId = 4, Size = "8" },
                        new { ItemSizeId = 5, Size = "9" },
                        new { ItemSizeId = 6, Size = "10" }
                    );
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("SneakerSeekerUserId");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("OrderId");

                    b.HasIndex("SneakerSeekerUserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("ItemColorId");

                    b.Property<string>("ProductDescription")
                        .IsRequired();

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<string>("ProductURL");

                    b.Property<string>("SKU");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int?>("sizeItemSizeId");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ItemColorId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("sizeItemSizeId");

                    b.ToTable("Product");

                    b.HasData(
                        new { ProductId = 1, CategoryId = 2, ItemColorId = 1, ProductDescription = "The lightest sneaker for daily life", ProductName = "Nike Red Sneaker - Women", ProductURL = "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details", SKU = "0001A", SupplierId = 1, UnitPrice = 200m },
                        new { ProductId = 2, CategoryId = 6, ItemColorId = 5, ProductDescription = "The classic Black Air Force 1 mixed with silver color", ProductName = "Nike Black Nike Air Force 1 Low - Men", ProductURL = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oplkqwyf7nwnj98f8agj/air-force-1-07-triple-black-mens-shoe-JkTGzADv.jpg", SKU = "0002A", SupplierId = 1, UnitPrice = 200m },
                        new { ProductId = 3, CategoryId = 5, ItemColorId = 4, ProductDescription = "The most modren on in Air Jordan Collection ", ProductName = "Nike Air Jordan - Men", ProductURL = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/z7i1be9xlxbbqwubh5yi/air-jordan-1-mid-shoe-VzFBKF.jpg", SKU = "0003A", SupplierId = 1, UnitPrice = 150m },
                        new { ProductId = 4, CategoryId = 6, ItemColorId = 2, ProductDescription = "Limited editin of Sb Suede Low-top", ProductName = "Nike Sb Suede Low-top Sneaker - Men", ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Zoom-Stefan-Janoski-Blue-%26-Sail-Suede-Shoes-_198814-0005-front.jpg", SKU = "0004A", SupplierId = 1, UnitPrice = 200m },
                        new { ProductId = 5, CategoryId = 2, ItemColorId = 3, ProductDescription = "The regular edtiton of women 2018", ProductName = "Nike Gray Sneaker 2018 - Women", ProductURL = "https://cdn.shopify.com/s/files/1/1512/2122/products/017_Mens_Mihara_Multi_Color_Canvas_Original_Sole_Sneaker-2_copy_1024x.jpg?v=1571772687", SKU = "0005A", SupplierId = 1, UnitPrice = 150m },
                        new { ProductId = 6, CategoryId = 5, ItemColorId = 2, ProductDescription = "Last collection of Adidas 2019", ProductName = "Adidas Yeezy Boost 350 Shoes - Men", ProductURL = "https://cdn.yoox.biz/45/45437288ff_13_n_f.jpg", SKU = "0006A", SupplierId = 2, UnitPrice = 200m },
                        new { ProductId = 7, CategoryId = 2, ItemColorId = 4, ProductDescription = "This adidas Originals NMD R1 merges the style you need", ProductName = "Adidas Originals NMD R1 sneakers - Men", ProductURL = "https://cdn-images.farfetch-contents.com/14/26/62/34/14266234_20084985_600.jpg", SKU = "0007A", SupplierId = 2, UnitPrice = 150m },
                        new { ProductId = 8, CategoryId = 5, ItemColorId = 5, ProductDescription = "One of the most popular Yeezy shoes ever made", ProductName = "Adidas Yeezy Boost 350 V2 shoes - women", ProductURL = "https://shop.r10s.jp/noel-ange/cabinet/shoes/adidas2/adi-d96635-al-a.jpg", SKU = "0008A", SupplierId = 2, UnitPrice = 200m },
                        new { ProductId = 9, CategoryId = 5, ItemColorId = 1, ProductDescription = "These shoes have a lightweight textile", ProductName = "Adidas LITE RACER RBN running shoes - Men", ProductURL = "https://assets.adidas.com/images/w_600,f_auto,q_auto:sensitive,fl_lossy/04fd20874e024a519fe3a99901315e1a_9366/Lite_Racer_RBN_Shoes_Black_F36783_01_standard.jpg", SKU = "0009A", SupplierId = 2, UnitPrice = 150m },
                        new { ProductId = 10, CategoryId = 3, ItemColorId = 4, ProductDescription = "This is the most faithful reproduction of the shell-toe shoes", ProductName = "Adidas originals superstar shoes - women", ProductURL = "https://images.bloomingdalesassets.com/is/image/BLM/products/7/optimized/9942107_fpx.tif?op_sharpen=1&wid=700&fit=fit,1&$filtersm$", SKU = "0010A", SupplierId = 2, UnitPrice = 200m },
                        new { ProductId = 11, CategoryId = 2, ItemColorId = 4, ProductDescription = "FILA’s most popular women’s silhouette", ProductName = "Fila Disruptor II Premium - Women", ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/FILA-Disruptor-Multicolor-%26-White-Shoes-_311646-front-US.jpg", SKU = "0011A", SupplierId = 4, UnitPrice = 200m },
                        new { ProductId = 12, CategoryId = 2, ItemColorId = 6, ProductDescription = "90's are back. This shoe has got a narrow fit", ProductName = "Fila DISRUPTOR M LOW - women", ProductURL = "https://photos.queens.cz/queens/2019-03/large/fila-disruptor-m-low-wmn-89669_1.jpg", SKU = "0012A", SupplierId = 4, UnitPrice = 200m },
                        new { ProductId = 13, CategoryId = 1, ItemColorId = 7, ProductDescription = "The Era, Vans classic low top lace-up skate shoe", ProductName = "Vans Era - Men", ProductURL = "https://imagescdn.simons.ca/images/8728-319317-60-A1_2/era-bright-red-sneakers-men.jpg?__=3", SKU = "0013A", SupplierId = 5, UnitPrice = 150m },
                        new { ProductId = 14, CategoryId = 1, ItemColorId = 1, ProductDescription = "The Authentic, Vans original and now iconic style, is a simple low top", ProductName = "Vans Authentic - Women", ProductURL = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/FILA-Disruptor-II-3D-Embroidery-White-Shoes-_323532-front-US.jpg", SKU = "0014A", SupplierId = 5, UnitPrice = 200m },
                        new { ProductId = 15, CategoryId = 2, ItemColorId = 8, ProductDescription = "This is one of three regional exclusive colorways that released in March 2019", ProductName = "Adidas Yeezy Boost 350 V2 - women", ProductURL = "https://www.biorley.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/j/j/jj657.jpg", SKU = "0015A", SupplierId = 2, UnitPrice = 150m },
                        new { ProductId = 16, CategoryId = 5, ItemColorId = 2, ProductDescription = "The first sneaker in the EQT line designed with the baller in mind", ProductName = "Adidas EQT Basketball ADV Unisex Running Soes - Men", ProductURL = "https://media.endclothing.com/media/catalog/product/2/3/23-03-2018_adidas_eqtbaskadvw_ashblue_white_ac7353_mg_1.jpg", SKU = "0016A", SupplierId = 2, UnitPrice = 200m },
                        new { ProductId = 17, CategoryId = 5, ItemColorId = 4, ProductDescription = "The Jordan Retro 13 is a retro version of the shoe MJ wore as he captured his sixth championship", ProductName = "Nike Jordan 13 Retro Alternate - Men", ProductURL = "https://stockx-360.imgix.net/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Images/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1546679301", SKU = "0017A", SupplierId = 1, UnitPrice = 150m },
                        new { ProductId = 18, CategoryId = 2, ItemColorId = 7, ProductDescription = "Keep your outfit cookin with a pair of these Nike Air Max 1", ProductName = "Nike Air Max 1 - women", ProductURL = "https://c.static-nike.com/a/images/t_prod_ss/w_960,c_limit,f_auto/ikvlpfgtitt6mybtdcug/nike-air-max-1-premium-dark-curry-release-date.jpg", SKU = "0018A", SupplierId = 1, UnitPrice = 200m },
                        new { ProductId = 19, CategoryId = 1, ItemColorId = 4, ProductDescription = "Stay fly. Stay fresh with most new style of 2019", ProductName = "Puma Clyde Core Lace - Women", ProductURL = "https://cfcdn.zulily.com/images/cache/product/452x1000/271852/zu54008569_main_tm1515613298.jpg", SKU = "0019A", SupplierId = 3, UnitPrice = 150m },
                        new { ProductId = 20, CategoryId = 5, ItemColorId = 4, ProductDescription = "In a fast-paced world, your senses need to be sharp", ProductName = "Puma LQDCELL Optic Sci-Fi Training Shoes - women", ProductURL = "https://images.puma.net/images/192941/02/sv01/fnd/PNA/w/600/h/600/", SKU = "0020A", SupplierId = 3, UnitPrice = 200m }
                    );
                });

            modelBuilder.Entity("SneakerSeeker3.Models.SneakerSeekerUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("CartId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FavouriteShoes");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.StoreRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("URL")
                        .IsRequired();

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");

                    b.HasData(
                        new { SupplierId = 1, CompanyName = "Nike", URL = "https://i.pinimg.com/originals/4d/96/2d/4d962dee72fa76f023d411e20d30690c.jpg" },
                        new { SupplierId = 2, CompanyName = "Adidas", URL = "https://seeklogo.com/images/A/adidas-logo-107B082DA0-seeklogo.com.png" },
                        new { SupplierId = 3, CompanyName = "Puma", URL = "https://seeklogo.com/images/P/Puma-logo-C1C1A4A6DF-seeklogo.com.png" },
                        new { SupplierId = 4, CompanyName = "Fila", URL = "https://seeklogo.com/images/F/fila-logo-C3B98A98FB-seeklogo.com.png" },
                        new { SupplierId = 5, CompanyName = "Vans", URL = "http://logosvg.com/wp-content/uploads/2017/02/Vans_logo.png" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.StoreRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.SneakerSeekerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.SneakerSeekerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.StoreRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SneakerSeeker3.Models.SneakerSeekerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.SneakerSeekerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Cart", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.Product", "Product")
                        .WithMany("Cart")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SneakerSeeker3.Models.ItemReview", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.Product", "Pro")
                        .WithMany("ItemReviews")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Order", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.SneakerSeekerUser")
                        .WithMany("Orders")
                        .HasForeignKey("SneakerSeekerUserId");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.OrderDetail", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SneakerSeeker3.Models.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SneakerSeeker3.Models.Product", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.Category", "Cat")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SneakerSeeker3.Models.ItemColor", "color")
                        .WithMany("Products")
                        .HasForeignKey("ItemColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SneakerSeeker3.Models.Supplier", "Sup")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SneakerSeeker3.Models.ItemSize", "size")
                        .WithMany("Products")
                        .HasForeignKey("sizeItemSizeId");
                });

            modelBuilder.Entity("SneakerSeeker3.Models.SneakerSeekerUser", b =>
                {
                    b.HasOne("SneakerSeeker3.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");
                });
#pragma warning restore 612, 618
        }
    }
}