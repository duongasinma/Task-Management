using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoIndentityCore.Migrations
{
    public partial class updateDateType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStart",
                table: "Tasks",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeEnd",
                table: "Tasks",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStart",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeEnd",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "fc8bf2f4-a73e-4975-886d-9848e9f5349f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1f78a6b-d19c-4751-b15e-c285d5ccf74d", "AQAAAAEAACcQAAAAELvEEYQAoxqOUxG15DFSQ0A3y3mWrbEgNULx6KsmakoJAvK5W8YHsSkICKXK4i/HDg==", "23151b06-b2c9-440b-8a0e-45a3391bb27d" });
        }
    }
}
