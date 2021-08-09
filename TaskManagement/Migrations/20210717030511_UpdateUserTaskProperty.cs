using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoIndentityCore.Migrations
{
    public partial class UpdateUserTaskProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Process",
                table: "UserTasks",
                newName: "UserTaskStatus");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "a3cc3507-24aa-4f57-8793-90e5bf6a0647");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b07fb239-eed4-4702-b52d-50d8962f2b4b", "AQAAAAEAACcQAAAAEA8uoXubImjaeIvZ7Sybf36U4nm/7vfNdGI3AZgWjkL4vwRIENmiGP1VmwuszCG84g==", "c8d88ab5-76b7-4528-bb54-d731dcfce76a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserTaskStatus",
                table: "UserTasks",
                newName: "Process");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "d243c722-bdf1-4904-b7ac-4015ed59d5b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e6fa467-e052-4d89-9ffd-4cb870eeaaf6", "AQAAAAEAACcQAAAAEFo+6eo7qLMweuPNsHBOJ8HHAaGM5iCUCzYEt+Xcbm8CCONwBQbiTgcNOuXLxFiaTA==", "d2741f2c-ca98-40ca-8a8d-689fde1a1460" });
        }
    }
}
