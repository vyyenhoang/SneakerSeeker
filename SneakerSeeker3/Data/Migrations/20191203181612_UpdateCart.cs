using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerSeeker3.Data.Migrations
{
    public partial class UpdateCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_CustId",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CustId",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavouriteShoes",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers",
                column: "CartId",
                unique: true,
                filter: "[CartId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cart_CartId",
                table: "AspNetUsers",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cart_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavouriteShoes",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CustId",
                table: "Cart",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustId",
                table: "Cart",
                column: "CustId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AspNetUsers_CustId",
                table: "Cart",
                column: "CustId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
