using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class DateRequestedupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-4433-9c54-c5e6cbc75463",
                column: "ConcurrencyStamp",
                value: "56528b58-765b-4b1a-9241-30adc3b4d048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                column: "ConcurrencyStamp",
                value: "7e412ec9-0548-4a3a-8f56-fead0225154a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45033ac-c5e3-48c7-8ea6-3a36d644b4c5", "AQAAAAEAACcQAAAAEFWQjHPjNSf33fSPvM5VeQ/Uj+JBS/LUjz10xXTN7GLWxja0IfGPSBcFvE8WIvewrQ==", "f0e9971c-b33f-4196-a1d2-2ee33b0f718a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e53920-3b26-4b6a-a92d-a89027b0b09c", "AQAAAAEAACcQAAAAEEb80wlHxOevy+MaQUkaZMgHJuB835WCgQi3AhqIlvqui0kEIQ9dhJIySOrGkxSQMQ==", "047861f7-3bcf-402d-96c0-a1d95e896e8a" });
        }
    }
}
