using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Basketball", "Shoes for basketball player" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Active", "CategoryName", "Description", "ImageURL" },
                values: new object[] { 4, true, "Running", "Shoes for runner", null });

            migrationBuilder.InsertData(
                table: "ItemColor",
                columns: new[] { "ItemColorId", "Color" },
                values: new object[] { 4, "Black" });

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 3,
                column: "Size",
                value: "3");

            migrationBuilder.InsertData(
                table: "ItemSize",
                columns: new[] { "ItemSizeId", "Size" },
                values: new object[] { 4, "4" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductName", "SKU" },
                values: new object[] { "This is a limited basketball shoes from Bitis", "Onemez Flash", "0003R" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 3,
                column: "URL",
                value: "https://www.logolynx.com/images/logolynx/00/00ea37cde6d4631b8be5409db9f25f3a.jpeg");

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "CompanyName", "URL" },
                values: new object[] { 4, "Wonderful Brand", "https://www.logolynx.com/images/logolynx/30/3069ba75b7888a74f8cd6033965b8e2a.png" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ItemColorId", "ItemSizeId", "ProductDescription", "ProductName", "ProductURL", "SKU", "SupplierId", "UnitPrice" },
                values: new object[] { 4, 4, 4, 4, "This is a limited running shoes from Bitis", "Anizuka Light", "https://i.dmarge.com/2019/05/feature-920x620.jpg", "0002B", 4, 200m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemColor",
                keyColumn: "ItemColorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sport Shoes", "Shoes for sport player" });

            migrationBuilder.UpdateData(
                table: "ItemSize",
                keyColumn: "ItemSizeId",
                keyValue: 3,
                column: "Size",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductName", "SKU" },
                values: new object[] { "This is a limited running shoes from Bitis", "Dancing Shoes", "0001R" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: 3,
                column: "URL",
                value: "");
        }
    }
}
