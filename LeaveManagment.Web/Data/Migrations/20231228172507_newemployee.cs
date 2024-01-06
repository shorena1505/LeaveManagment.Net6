using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class newemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "ConcurrencyStamp",
                value: "14bcb8c5-6ec1-47de-b528-0ce7f84d4b8e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-5544-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1f1306c-4811-4f2e-9e62-bb784808512b", "AQAAAAEAACcQAAAAEJNRRJIHfcVx4k6Qj8040IdUEG9jw56IEkPLKT/2+++w+wROePgTx9TrqwYYquNdCw==", "5dc8fab9-e6ef-4185-a83d-b9db6b7139c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68ed79b6-9d33-4be1-a88b-c30b084c784b", "AQAAAAEAACcQAAAAEE17kaRQFp232Mp+3mxIOYPYrl8voO6nRMtpwQazIPaZdyXiE+fnUrftvGMFAKlJvA==", "904f660a-2ab0-451f-836e-5fe3d2b378d4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "e27714b4-3420-48c6-82d1-f5a6bce11990");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "ca7907ce-a4fa-4e32-b63a-f6a8a6ea3185");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-5544-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "268ec9b0-326f-4b62-a298-b143786c46b5", "AQAAAAEAACcQAAAAEJhTe1+C+XhXABKFk/GLrL5sQ7CEBN+psCdARmg+8g2Yo1UjzNWS6053FQIeJhVeWA==", "8fe2e056-ca3b-4e44-8014-3cc0be2b48ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f1da927-def2-42e8-a6d0-8abdbdbb2a07", "AQAAAAEAACcQAAAAEOZKkneg4XGWgJbM0+/UZL+YZKHBY8nVb4SeKxmdmQhXwhnYW7BblRhrk/izmkjlPg==", "2ed0e2a6-a872-4754-bd17-cc389f4d5387" });
        }
    }
}
