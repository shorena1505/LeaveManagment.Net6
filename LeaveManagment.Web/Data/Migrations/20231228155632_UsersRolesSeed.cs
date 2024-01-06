using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class UsersRolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32cb1c44-74ac-4433-9c54-c5e6cbc75463", "e27714b4-3420-48c6-82d1-f5a6bce11990", "User", "USER" },
                    { "32cb1c44-74ac-8888-9c54-c5e6cbc74821", "ca7907ce-a4fa-4e32-b63a-f6a8a6ea3185", "Administrator", "AdMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32cb1c44-74ac-5544-9c54-c5e6cbc74821", 0, "268ec9b0-326f-4b62-a298-b143786c46b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "Shorena", "Nemsadze", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJhTe1+C+XhXABKFk/GLrL5sQ7CEBN+psCdARmg+8g2Yo1UjzNWS6053FQIeJhVeWA==", null, false, "8fe2e056-ca3b-4e44-8014-3cc0be2b48ea", null, false, "admin@localhost.com" },
                    { "32cb1c44-74ac-7204-9c54-c5e6cbc74821", 0, "9f1da927-def2-42e8-a6d0-8abdbdbb2a07", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "Petre", "Oglu", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOZKkneg4XGWgJbM0+/UZL+YZKHBY8nVb4SeKxmdmQhXwhnYW7BblRhrk/izmkjlPg==", null, false, "2ed0e2a6-a872-4754-bd17-cc389f4d5387", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "32cb1c44-74ac-8888-9c54-c5e6cbc74821", "32cb1c44-74ac-5544-9c54-c5e6cbc74821" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32cb1c44-74ac-8888-9c54-c5e6cbc74821", "32cb1c44-74ac-5544-9c54-c5e6cbc74821" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-5544-9c54-c5e6cbc74821");
        }
    }
}
