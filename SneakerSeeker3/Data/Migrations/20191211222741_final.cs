using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "The best sneakers are here");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Enjoy running by our shoes");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "The perfect fit for your style");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Basketball", "Enjoy playing basketball by our best shoes" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Formal", "For professional life style" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Football", "For every smoth football game" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UnitPrice",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "UnitPrice",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "UnitPrice",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 2, 70m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://images.journeys.com/images/products/1_224909_ZM_BLUE_ALT1.JPG", 85m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "UnitPrice",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 4, 180m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "UnitPrice",
                value: 90m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "UnitPrice",
                value: 70m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 1, 85m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ItemColorId", "ProductURL", "UnitPrice" },
                values: new object[] { 2, "http://www.chamberschaos.com/wp-content/uploads/2018/05/vans-slip-on-pro-allen-navy-white-skate-shoes-blue-mens-skate-shoes.jpg", 70m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductURL",
                value: "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/adidas-Xplorer-Ice-Pink-Shoes-_311952.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "UnitPrice",
                value: 140m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Nyjah-Free-White-Skate-Shoes-_290339.jpg", 100m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "UnitPrice",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://dsw.scene7.com/is/image/DSWShoes/447627_100_ss_01?$colpg$", 60m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "ItemColorId", "ProductURL", "UnitPrice" },
                values: new object[] { 3, "https://i.pinimg.com/originals/50/7f/bd/507fbd1acb876b460384daeb03246540.jpg", 40m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Sneakers for Women");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Running for Women");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Casual for Wome");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sneakers", "Sneakers for Men" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Running", "Running shoes for Men" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Casual", "Casual shoes for Men" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "UnitPrice",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 3, 150m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://cdn.yoox.biz/45/45437288ff_13_n_f.jpg", 200m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "UnitPrice",
                value: 150m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 5, 200m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ItemColorId", "UnitPrice" },
                values: new object[] { 7, 150m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ItemColorId", "ProductURL", "UnitPrice" },
                values: new object[] { 1, "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/FILA-Disruptor-II-3D-Embroidery-White-Shoes-_323532-front-US.jpg", 200m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductURL",
                value: "https://www.biorley.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/j/j/jj657.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://stockx-360.imgix.net/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Images/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1546679301", 150m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "UnitPrice",
                value: 200m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "ProductURL", "UnitPrice" },
                values: new object[] { "https://cfcdn.zulily.com/images/cache/product/452x1000/271852/zu54008569_main_tm1515613298.jpg", 150m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "ItemColorId", "ProductURL", "UnitPrice" },
                values: new object[] { 4, "https://images.puma.net/images/192941/02/sv01/fnd/PNA/w/600/h/600/", 200m });
        }
    }
}
