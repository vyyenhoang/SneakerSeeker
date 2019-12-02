using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class updateimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductURL",
                value: "https://www.famousfootwear.com/ProductImages/shoes_ia92569.jpg?preset=details");

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
                keyValue: 4,
                column: "ProductURL",
                value: "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Nike-SB-Zoom-Stefan-Janoski-Blue-%26-Sail-Suede-Shoes-_198814-0005-front.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductURL",
                value: "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/1/4/142004_01.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductURL",
                value: "https://stockx-360.imgix.net/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Images/Adidas-Yeezy-Boost-350-V2-Beluga-2pt0/Lv2/img01.jpg?auto=format,compress&q=90&updated_at=1538080256&w=1000");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductURL",
                value: "https://cdn-images.farfetch-contents.com/14/26/62/34/14266234_20084985_600.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ProductURL",
                value: "https://shop.r10s.jp/noel-ange/cabinet/shoes/adidas2/adi-d96635-al-a.jpg");

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
                keyValue: 11,
                column: "ProductURL",
                value: "https://imgs.inkfrog.com/pix/baybayshoes/Womens-Fila-Disruptor-2-Premium-White-White-1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ProductURL",
                value: "https://photos.queens.cz/queens/2019-03/large/fila-disruptor-m-low-wmn-89669_1.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductURL",
                value: "https://i.ebayimg.com/images/g/ZyoAAOSwymxVLUsC/s-l300.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ProductURL",
                value: "https://i.pinimg.com/originals/79/6a/91/796a91d60f78538d661adc79490f3261.jpg");

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "ProductURL",
                value: "https://cfcdn.zulily.com/images/cache/product/452x1000/271852/zu54008569_main_tm1515613298.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "ProductURL",
                value: "https://images.puma.net/images/192941/02/sv01/fnd/PNA/w/600/h/600/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/2859181/pexels-photo-2859181.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/2692460/pexels-photo-2692460.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/1503009/pexels-photo-1503009.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/2729899/pexels-photo-2729899.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/1280064/pexels-photo-1280064.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1555274175-6cbf6f3b137b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1488704906310-183eeda75d51?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2100&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1515780244948-9e4ea7fb969d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1532471965572-092fb677a6a1?ixlib=rb-1.2.1&auto=format&fit=crop&w=934&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1509913841876-b8a297b4e240?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3150&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1557161187-fba28578f4ed?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/1598508/pexels-photo-1598508.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1565299999261-28ba859019bb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1554735490-5974588cbc4f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1520256788229-d4640c632e4b?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1537636568536-a2e00b44cb85?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=965&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1514989940723-e8e51635b782?ixlib=rb-1.2.1&auto=format&fit=crop&w=2100&q=80");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "ProductURL",
                value: "https://images.pexels.com/photos/2759783/pexels-photo-2759783.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "ProductURL",
                value: "https://images.unsplash.com/photo-1509442233604-131901ff8d40?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80");
        }
    }
}
