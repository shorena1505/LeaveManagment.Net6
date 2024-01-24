using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-5544-9c54-c5e6cbc74821");

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "38d256c1-70a8-4830-b402-1f1da0a95c10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "80c8307b-1cb9-4939-b0cc-06af02318f33", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cac38a1-3260-49c1-950a-b29f23d88006", "AQAAAAEAACcQAAAAELK68k9+I2U1QU99Dn92iOnMbVF/KaoVbSMq8G0fGtkCVNuoKX1Vw81rzU54M+LOMw==", "8cffb60d-a821-4a7b-b8cd-d079e7c46f4a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32cb1c44-74ac-8888-9c54-c5e6cbc74821", 0, "605a58c1-b8c6-4f4b-8245-05dfbb8bddd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@localhost.com", true, "Shorena", "Nemsadze", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIRQhrvem4XuuKGMgqp3yUqQxsFI6SscN294TWZst1JufFkBwA3UlqTFhDb08TKujA==", null, false, "e4f95fd0-9c6c-4c45-b857-f36eb3cf4969", null, false, "Admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "8315b9f0-510b-45dd-9ee6-cbb918fcb9c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "14bcb8c5-6ec1-47de-b528-0ce7f84d4b8e", "AdMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68ed79b6-9d33-4be1-a88b-c30b084c784b", "AQAAAAEAACcQAAAAEE17kaRQFp232Mp+3mxIOYPYrl8voO6nRMtpwQazIPaZdyXiE+fnUrftvGMFAKlJvA==", "904f660a-2ab0-451f-836e-5fe3d2b378d4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32cb1c44-74ac-5544-9c54-c5e6cbc74821", 0, "b1f1306c-4811-4f2e-9e62-bb784808512b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "Shorena", "Nemsadze", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJNRRJIHfcVx4k6Qj8040IdUEG9jw56IEkPLKT/2+++w+wROePgTx9TrqwYYquNdCw==", null, false, "5dc8fab9-e6ef-4185-a83d-b9db6b7139c6", null, false, "admin@localhost.com" });
        }
    }
}
