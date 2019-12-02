using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class UpdateImages2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductURL",
                value: "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oplkqwyf7nwnj98f8agj/air-force-1-07-triple-black-mens-shoe-JkTGzADv.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductURL",
                value: "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/z7i1be9xlxbbqwubh5yi/air-jordan-1-mid-shoe-VzFBKF.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductURL",
                value: "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/8/0/802389_01.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductURL",
                value: "https://assets.adidas.com/images/w_600,f_auto,q_auto:sensitive,fl_lossy/04fd20874e024a519fe3a99901315e1a_9366/Lite_Racer_RBN_Shoes_Black_F36783_01_standard.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductURL",
                value: "https://images.bloomingdalesassets.com/is/image/BLM/products/7/optimized/9942107_fpx.tif?op_sharpen=1&wid=700&fit=fit,1&$filtersm$");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductURL",
                value: "https://imagescdn.simons.ca/images/8728-319317-60-A1_2/era-bright-red-sneakers-men.jpg?__=3");

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
                column: "ProductURL",
                value: "https://media.endclothing.com/media/catalog/product/2/3/23-03-2018_adidas_eqtbaskadvw_ashblue_white_ac7353_mg_1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ProductURL",
                value: "https://www.snkronline.com/media/catalog/product/cache/1/image/1200x1200/9df78eab33525d08d6e5fb8d27136e95/4/1/414571-103_1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "ProductURL",
                value: "https://c.static-nike.com/a/images/t_prod_ss/w_960,c_limit,f_auto/ikvlpfgtitt6mybtdcug/nike-air-max-1-premium-dark-curry-release-date.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductURL",
                value: "https://stockx-360.imgix.net/Nike-Air-Force-1-Low-Off-White-Black-White/Images/Nike-Air-Force-1-Low-Off-White-Black-White/Lv2/img01.jpg?auto=format,compress&q=90&updated_at=1546755764&w=1000");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductURL",
                value: "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/8/0/800375_01.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductURL",
                value: "https://stockx-360.imgix.net/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Images/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Lv2/img01.jpg?auto=format,compress&q=90&updated_at=1538080256&w=1000");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductURL",
                value: "https://images.worshipsport.com/images/201706/uploaded/8b38ab33f027b9d73cee1d9c3baaaac5.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/416b9WqRzRL.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductURL",
                value: "https://i.ebayimg.com/images/g/ZyoAAOSwymxVLUsC/s-l300.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductURL",
                value: "http://www.adidas--trainers.co.uk/images/images/NC1A9366.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ProductURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/81b65XylZ3L._UX500_.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ProductURL",
                value: "https://stockx.imgix.net/Air-Jordan-13-Retro-Alternate-History-Of-Flight-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1546679301");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "ProductURL",
                value: "https://stockx-360.imgix.net/Nike-Air-Max-1-Curry-2018/Images/Nike-Air-Max-1-Curry-2018/Lv2/img06.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1538080256");
        }
    }
}
