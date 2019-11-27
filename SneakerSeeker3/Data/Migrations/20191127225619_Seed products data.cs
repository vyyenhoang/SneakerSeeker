using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class Seedproductsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Cart_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItem");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItem",
                newName: "IX_CartItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Casual", "Casual for Wome" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sneakers", "Sneakers for Men" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Active", "CategoryName", "Description", "ImageURL" },
                values: new object[,]
                {
                    { 1, true, "Sneakers", "Sneakers for Women", null },
                    { 2, true, "Running", "Running for Women", null },
                    { 5, true, "Running", "Running shoes for Men", null },
                    { 6, true, "Casual", "Casual shoes for Men", null }
                });

            migrationBuilder.UpdateData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 3,
                column: "Color",
                value: "Gray");

            migrationBuilder.UpdateData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 4,
                column: "Color",
                value: "White");

            migrationBuilder.InsertData(
                table: "ItemColor",
                columns: new[] { "ItemColorId", "Color" },
                values: new object[,]
                {
                    { 8, "Pink" },
                    { 6, "Silver" },
                    { 7, "Curry" },
                    { 2, "Blue" },
                    { 1, "Red" },
                    { 5, "Black" }
                });

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 3,
                column: "Size",
                value: "7");

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 4,
                column: "Size",
                value: "8");

            migrationBuilder.InsertData(
                table: "ItemSize",
                columns: new[] { "ItemSizeId", "Size" },
                values: new object[,]
                {
                    { 1, "5" },
                    { 2, "6" },
                    { 5, "9" },
                    { 6, "10" }
                });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 3,
                columns: new[] { "CompanyName", "URL" },
                values: new object[] { "Puma", "https://seeklogo.com/images/P/Puma-logo-C1C1A4A6DF-seeklogo.com.png" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 4,
                columns: new[] { "CompanyName", "URL" },
                values: new object[] { "Fila", "https://seeklogo.com/images/F/fila-logo-C3B98A98FB-seeklogo.com.png" });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "CompanyName", "URL" },
                values: new object[,]
                {
                    { 1, "Nike", "https://i.pinimg.com/originals/4d/96/2d/4d962dee72fa76f023d411e20d30690c.jpg" },
                    { 2, "Adidas", "https://seeklogo.com/images/A/adidas-logo-107B082DA0-seeklogo.com.png" },
                    { 5, "Vans", "http://logosvg.com/wp-content/uploads/2017/02/Vans_logo.png" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ItemColorId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId" },
                values: new object[] { 5, 4, "The most modren on in Air Jordan Collection ", "Nike Air Jordan - Men", "https://images.pexels.com/photos/2692460/pexels-photo-2692460.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0003A", 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ItemColorId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId" },
                values: new object[] { 6, 2, "Limited editin of Sb Suede Low-top", "Nike Sb Suede Low-top Sneaker - Men", "https://images.pexels.com/photos/1503009/pexels-photo-1503009.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0004A", 1 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ItemColorId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId", "UnitPrice", "sizeItemSizeId" },
                values: new object[,]
                {
                    { 19, 1, 4, "Stay fly. Stay fresh with most new style of 2019", "Puma Clyde Core Lace - Women", "https://images.pexels.com/photos/2759783/pexels-photo-2759783.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0019A", 3, 150m, null },
                    { 16, 5, 2, "The first sneaker in the EQT line designed with the baller in mind", "Adidas EQT Basketball ADV Unisex Running Soes - Men", "https://images.unsplash.com/photo-1520256788229-d4640c632e4b?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80", "0016A", 2, 200m, null },
                    { 15, 2, 8, "This is one of three regional exclusive colorways that released in March 2019", "Adidas Yeezy Boost 350 V2 - women", "https://images.unsplash.com/photo-1554735490-5974588cbc4f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80", "0015A", 2, 150m, null },
                    { 10, 3, 4, "This is the most faithful reproduction of the shell-toe shoes", "Adidas originals superstar shoes - women", "https://images.unsplash.com/photo-1532471965572-092fb677a6a1?ixlib=rb-1.2.1&auto=format&fit=crop&w=934&q=80", "0010A", 2, 200m, null },
                    { 9, 5, 1, "These shoes have a lightweight textile", "Adidas LITE RACER RBN running shoes - Men", "https://images.unsplash.com/photo-1515780244948-9e4ea7fb969d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80", "0009A", 2, 150m, null },
                    { 8, 5, 5, "One of the most popular Yeezy shoes ever made", "Adidas Yeezy Boost 350 V2 shoes - women", "https://images.unsplash.com/photo-1488704906310-183eeda75d51?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80", "0008A", 2, 200m, null },
                    { 7, 2, 4, "This adidas Originals NMD R1 merges the style you need", "Adidas Originals NMD R1 sneakers - Men", "https://images.unsplash.com/photo-1555274175-6cbf6f3b137b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80", "0007A", 2, 150m, null },
                    { 6, 5, 2, "Last collection of Adidas 2019", "Adidas Yeezy Boost 350 Shoes - Men", "https://images.pexels.com/photos/1280064/pexels-photo-1280064.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0006A", 2, 200m, null },
                    { 17, 5, 4, "The Jordan Retro 13 is a retro version of the shoe MJ wore as he captured his sixth championship", "Nike Jordan 13 Retro Alternate - Men", "https://images.unsplash.com/photo-1537636568536-a2e00b44cb85?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=965&q=80", "0017A", 1, 150m, null },
                    { 13, 1, 7, "The Era, Vans classic low top lace-up skate shoe", "Vans Era - Men", "https://images.pexels.com/photos/1598508/pexels-photo-1598508.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0013A", 5, 150m, null },
                    { 5, 2, 3, "The regular edtiton of women 2018", "Nike Gray Sneaker 2018 - Women", "https://images.pexels.com/photos/2729899/pexels-photo-2729899.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0005A", 1, 150m, null },
                    { 2, 6, 5, "The classic Black Air Force 1 mixed with silver color", "Nike Black Nike Air Force 1 Low - Men", "https://images.pexels.com/photos/2859181/pexels-photo-2859181.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260", "0002A", 1, 200m, null },
                    { 1, 2, 1, "The lightest sneaker for daily life", "Nike Red Sneaker - Women", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80", "0001A", 1, 200m, null },
                    { 12, 2, 6, "90's are back. This shoe has got a narrow fit", "Fila DISRUPTOR M LOW - women", "https://images.unsplash.com/photo-1557161187-fba28578f4ed?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80", "0012A", 4, 200m, null },
                    { 20, 5, 4, "In a fast-paced world, your senses need to be sharp", "Puma LQDCELL Optic Sci-Fi Training Shoes - women", "https://images.unsplash.com/photo-1509442233604-131901ff8d40?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80", "0020A", 3, 200m, null },
                    { 11, 2, 4, "FILA’s most popular women’s silhouette", "Fila Disruptor II Premium - Women", "https://images.unsplash.com/photo-1509913841876-b8a297b4e240?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80", "0011A", 4, 200m, null },
                    { 18, 2, 7, "Keep your outfit cookin with a pair of these Nike Air Max 1", "Nike Air Max 1 - women", "https://images.unsplash.com/photo-1514989940723-e8e51635b782?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80", "0018A", 1, 200m, null },
                    { 14, 1, 1, "The Authentic, Vans original and now iconic style, is a simple low top", "Vans Authentic - Women", "https://images.unsplash.com/photo-1565299999261-28ba859019bb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80", "0014A", 5, 200m, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Product_ProductId",
                table: "CartItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Product_ProductId",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.DeleteData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "CartItem",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Basketball", "Shoes for basketball player" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Running", "Shoes for runner" });

            migrationBuilder.UpdateData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 3,
                column: "Color",
                value: "Yellow");

            migrationBuilder.UpdateData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 4,
                column: "Color",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 3,
                column: "Size",
                value: "3");

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 4,
                column: "Size",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ItemColorId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId" },
                values: new object[] { 3, 3, "This is a limited basketball shoes from Bitis", "Onemez Flash", "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details", "0003R", 3 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ItemColorId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId" },
                values: new object[] { 4, 4, "This is a limited running shoes from Bitis", "Anizuka Light", "https://i.dmarge.com/2019/05/feature-920x620.jpg", "0002B", 4 });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 3,
                columns: new[] { "CompanyName", "URL" },
                values: new object[] { "Bitis", "https://www.logolynx.com/images/logolynx/00/00ea37cde6d4631b8be5409db9f25f3a.jpeg" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 4,
                columns: new[] { "CompanyName", "URL" },
                values: new object[] { "Wonderful Brand", "https://www.logolynx.com/images/logolynx/30/3069ba75b7888a74f8cd6033965b8e2a.png" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Cart_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
