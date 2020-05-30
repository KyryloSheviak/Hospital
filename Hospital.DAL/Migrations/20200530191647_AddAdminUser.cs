using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.DAL.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d450a991-b508-4c54-a8b3-5644c5f60ef8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e32b5d00-32f7-4028-aad8-60c869bb11be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a3e90a2d-fcf6-44b0-9550-6f54b1cc5653");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c3352272-cad5-4105-8de6-31fdf6c68deb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d5258201-926c-4f2a-ae32-6659e8f2f88a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Fio", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "495389a3-c4bc-4c28-8402-10dfb42c3c9f", "admin@gmail.com", "ADMIN@GMAIL.COM", "b8756fdf-d34b-427d-8d92-c5fa85362d09" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "55fab7e5-992b-4f91-8b3c-d7433f041b2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "04362880-50cd-4c5a-9c94-27378d9e864b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d8335eb1-b114-493e-bd06-25d3f69eda5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "edfa4a8d-e470-4489-a05c-0a7aaca3542f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "6828d2cc-f2d1-490a-ba3a-371e46c427d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Fio", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "68a6b9fe-10b6-4135-8da9-229dcd6cff46", null, null, "0e76bb75-558e-45f4-9190-797af74e859d" });
        }
    }
}
