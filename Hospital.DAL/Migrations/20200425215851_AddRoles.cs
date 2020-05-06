using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.DAL.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "ca9e5a3c-5f7c-4aaf-be5f-f5ac92f3fd7d", "admin", null },
                    { 2, "eb9c291a-2d2e-4375-bcf9-5e0e0cb8a071", "user", null },
                    { 3, "70a7a76a-1b3b-46c4-b264-def12fcae586", "doctor", null },
                    { 4, "5699973a-68f7-4175-92c8-510cce3d1827", "patient", null },
                    { 5, "654a3578-e494-4c95-9ab3-15435dc29dbd", "manager", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
