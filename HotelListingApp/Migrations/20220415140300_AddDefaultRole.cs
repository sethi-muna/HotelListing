using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingApp.Migrations
{
    public partial class AddDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "677c9e5d-b0d9-48c5-b743-d546101ab960", "9162ed53-7606-485b-9531-5b41e6e3cf24", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c691b309-4973-4e11-852d-e6bada73c714", "23a8d314-ce57-433f-8f4e-8953b9513a39", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "677c9e5d-b0d9-48c5-b743-d546101ab960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c691b309-4973-4e11-852d-e6bada73c714");
        }
    }
}
