using Microsoft.EntityFrameworkCore.Migrations;

namespace Perpustakaan.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cf3ee2c-ca45-44a8-8a57-08b15b06bf3f", "0e765116-a20a-4222-88e0-69ac58f258f2", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4376a3bb-954e-438b-9dac-8889a42a470c", "93ec5c33-d8f4-412f-b6c9-81bc0a2c7e7c", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cc641b6e-6e61-44d8-acb1-aeba3ce7f62e", 0, "acd804df-7fca-49db-81af-51c83d54fc4e", "dwimul@admin.com", true, false, null, "Mulyono", "DWIMUL@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEFyXwsfhShwkry+sLx2fR4BcynKHrWe94ZpswLk+fK+XcYm3LQ4NxCJNNtmtNgV2Sw==", null, false, "d6a851e2-1af2-49ad-8be5-1ed899c65f5e", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4376a3bb-954e-438b-9dac-8889a42a470c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cf3ee2c-ca45-44a8-8a57-08b15b06bf3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc641b6e-6e61-44d8-acb1-aeba3ce7f62e");
        }
    }
}
