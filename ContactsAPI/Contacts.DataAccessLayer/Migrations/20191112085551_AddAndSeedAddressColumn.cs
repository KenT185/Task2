using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.DataAccessLayer.Migrations
{
    public partial class AddAndSeedAddressColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Lazurowa 42A");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address",
                value: "Szamocka 8");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: "Górczewska 22");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");
        }
    }
}
