using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedRequestTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DataRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
                column: "ConcurrencyStamp",
                value: "80c8307b-1cb9-4939-b0cc-06af02318f33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cac38a1-3260-49c1-950a-b29f23d88006", "AQAAAAEAACcQAAAAELK68k9+I2U1QU99Dn92iOnMbVF/KaoVbSMq8G0fGtkCVNuoKX1Vw81rzU54M+LOMw==", "8cffb60d-a821-4a7b-b8cd-d079e7c46f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "605a58c1-b8c6-4f4b-8245-05dfbb8bddd3", "AQAAAAEAACcQAAAAEIRQhrvem4XuuKGMgqp3yUqQxsFI6SscN294TWZst1JufFkBwA3UlqTFhDb08TKujA==", "e4f95fd0-9c6c-4c45-b857-f36eb3cf4969" });
        }
    }
}
