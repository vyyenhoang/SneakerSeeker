using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ItemSize_ItemSizeId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ItemSizeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ItemSizeId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "sizeItemSizeId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_sizeItemSizeId",
                table: "Product",
                column: "sizeItemSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ItemSize_sizeItemSizeId",
                table: "Product",
                column: "sizeItemSizeId",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ItemSize_sizeItemSizeId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_sizeItemSizeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "sizeItemSizeId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ItemSizeId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ItemSizeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ItemSizeId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ItemSizeId",
                table: "Product",
                column: "ItemSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ItemSize_ItemSizeId",
                table: "Product",
                column: "ItemSizeId",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
