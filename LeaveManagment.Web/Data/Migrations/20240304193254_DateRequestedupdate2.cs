using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class DateRequestedupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataRequested",
                table: "LeaveRequests",
                newName: "DateRequested");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "9d238666-1d32-4e95-8f67-12979b22cad0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "b503941e-d31e-4e37-89e4-3bf745cac732");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dce69db5-04b4-4485-89c5-ab8bcfeebd1a", "AQAAAAEAACcQAAAAEHLbCWJlmXfMZEfY4lhGWvi9lmh7M0d0ttR+XNQVqh+Mygg0YatVgpd0HX18UJlZdA==", "ed3ee11c-c8c5-440e-a833-70952329dd3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8de64a7-0fb3-4a63-8e81-35a3da7bfa86", "AQAAAAEAACcQAAAAEO5FKg5k/X6Mlxj1AR0koLuJH7tSPCfEBO3cp0gcoYUWDfemn3/aRzuTICsb9NmJTg==", "6a64b89f-9025-4ed6-8645-530c8299b4a1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRequested",
                table: "LeaveRequests",
                newName: "DataRequested");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "a1d16e45-2cd8-4aa1-a295-4f88f6d4d493");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "c6127423-f88f-4f96-8033-30b9e221c8f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a8e5179-9ebe-41e1-ab6a-bd1e3a9898cb", "AQAAAAEAACcQAAAAEKEt29Rllfdssr/8/dlVxzPSHVcmWYPq9UaLnct26ij/arckUQC/d/r6VVr8390MvA==", "109275ec-4142-4499-8540-4dbd8ff23708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26196dff-b043-4ec0-851b-7cb1396d1958", "AQAAAAEAACcQAAAAEJf1VRrNgumFYKNjEc6ttfaQ2qAUEqgThFqhOxEsCCGxC1a/JfDpbrft6g2B3XMSFg==", "eb940fea-c776-4871-86c5-dc74aea58cdf" });
        }
    }
}
