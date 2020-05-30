﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cbf7aa41-bf76-4558-8f24-7d9738836c39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "de594b27-930d-4a2e-bb9e-8b8dfe607de6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "bab6654c-1250-4078-830d-ac349adaf623");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "00b10b6a-a6e4-4784-b2c5-4e58072ce828");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "401adb89-3ced-42b9-9fc4-68176cf81fea");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "DoctorId", "Email", "EmailConfirmed", "Fio", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PatientId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01f7dffa-3ed4-4c61-8131-9f5e4e54b965", 0, "adminTest@gmail.com", false, null, false, null, "ADMINTEST@GMAIL.COM", null, "AQAAAAEAACcQAAAAEAju1DJkAZGmRKbPPr7g9P98dCkqAS/Rv3TsLa1sOu/rZ7O71Y7gDcpsjS2sKEKPRQ==", 0, null, false, "b20538d0-4b0c-45d5-8eed-0973ee1721d1", " ", false, "adminTest@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "DoctorId", "Email", "EmailConfirmed", "Fio", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PatientId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "495389a3-c4bc-4c28-8402-10dfb42c3c9f", 0, "admin@gmail.com", false, "admin@gmail.com", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAju1DJkAZGmRKbPPr7g9P98dCkqAS/Rv3TsLa1sOu/rZ7O71Y7gDcpsjS2sKEKPRQ==", 0, null, false, "b8756fdf-d34b-427d-8d92-c5fa85362d09", " ", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 1, 1 });
        }
    }
}
