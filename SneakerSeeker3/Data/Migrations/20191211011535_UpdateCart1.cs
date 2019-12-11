using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class UpdateCart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ProductURL",
                value: "https://stockx-360.imgix.net/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Images/Air-Jordan-13-Retro-Alternate-History-Of-Flight/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1546679301");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ProductURL",
                value: "https://www.flightclub.com/media/catalog/product/cache/1/image/1600x1140/9df78eab33525d08d6e5fb8d27136e95/8/0/801265_1.jpg");
        }
    }
}
