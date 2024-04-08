using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopBooks.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dodaneKompanije : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[] { 1, "Osijek", "Kompanija", "0993132524", "31000", "OBZ", "Ulica" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
