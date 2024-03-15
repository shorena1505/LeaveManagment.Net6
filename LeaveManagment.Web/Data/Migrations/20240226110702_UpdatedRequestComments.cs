using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "f3715828-8d49-4a41-89db-1c54f0046638");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "4c981177-c069-4e5f-99b5-0370050649c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a84473b3-0246-48cc-ab58-3587e88c0104", "AQAAAAEAACcQAAAAEMfAHtCFLK/VfTVyR9GUbij5ZPXmkEmlVmPzMwFE6NiFrxDtAWwuHL7M5R/CFyFMWw==", "3248216c-0d35-4b7e-bfed-4210fb27d54e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2b9a069-3193-4cf8-82db-2550a2a0dd50", "AQAAAAEAACcQAAAAEFSxo1cuc12QZepGrMm79cuJnIwZs6AY5R0dPLVaLMKrTRG350Rst9Yh3SBf6gJufg==", "2654ea94-316d-40be-923d-45fe603128c6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "93b8cb48-6709-42ed-a21f-bac6d73fc030");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "af95acda-6387-4786-af87-ea142fd75798");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dc30afa-fa35-4220-befd-1207c69f28da", "AQAAAAEAACcQAAAAEAQPbARlfro2gghIRhv9A2bIv/nxL9ej8uJZA1qkLJqbY0nR/Ejj1wvJd8i5gqmOjA==", "b56914ce-2c6c-48cb-9402-a7955f7a14ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df09a12-20fd-442d-a69a-ff0f4cc775aa", "AQAAAAEAACcQAAAAENa1WOOXN0u0FtUYwQc5rurWrGW4GtOhV+gNRoRV2TrYVO9Sf/fT2XXitJAeQX2tGQ==", "a4bf2c02-45b6-4a39-baa6-151ec6709e9d" });
        }
    }
}
