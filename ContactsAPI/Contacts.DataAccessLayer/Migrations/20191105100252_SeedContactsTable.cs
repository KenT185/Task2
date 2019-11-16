using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.DataAccessLayer.Migrations
{
    public partial class SeedContactsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 1, "mail1@o2.pl", "Name1", "123456789", "Surname1" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 2, "mail2@o2.pl", "Name2", "9876543", "Surname2" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 3, "mail3@o2.pl", "Name3", "333333333", "Surname3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
