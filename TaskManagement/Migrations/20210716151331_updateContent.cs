using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoIndentityCore.Migrations
{
    public partial class updateContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Tasks",
                newName: "Contentt");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contentt",
                table: "Tasks",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "ConcurrencyStamp",
                value: "5578dfd9-3b0e-40cf-9e96-a70424561a82");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376a2849-a8a9-4497-80dc-48cecaa59929", "AQAAAAEAACcQAAAAENkflCXGUYWneFJKAThYIThRRFt7+JZrVbpM/riDcNEJ4LnoTELHKJziY5yfdOJpdw==", "00415230-d910-4f7d-9577-0fdb78969eab" });
        }
    }
}
