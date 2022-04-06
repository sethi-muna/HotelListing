using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingApp.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "SortName" },
                values: new object[] { 1, "United State", "US" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "SortName" },
                values: new object[] { 2, "India", "IN" });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountyId", "Name", "Rating" },
                values: new object[] { 1, "Wasigton Dc", 1, "New Demon Hotel", 2.1000000000000001 });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountyId", "Name", "Rating" },
                values: new object[] { 2, "Delhi", 2, "Taj Hotel", 3.2000000000000002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
