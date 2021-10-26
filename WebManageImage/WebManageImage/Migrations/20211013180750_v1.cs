using Microsoft.EntityFrameworkCore.Migrations;

namespace WebManageImage.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d247859-11f4-41cd-ba94-4e7ef522fdbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c95195-5446-4642-862b-ae4b54e18926");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42ba2992-fd4e-4114-89f7-44b498f0541e", "fbe6d1f8-b41a-4b02-a53e-7d79bde09403", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c5e84c1-bcbc-4df8-9eda-124620b0e26a", "dd3a3005-6680-4a08-954c-62d8b86d85ef", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42ba2992-fd4e-4114-89f7-44b498f0541e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c5e84c1-bcbc-4df8-9eda-124620b0e26a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d247859-11f4-41cd-ba94-4e7ef522fdbe", "738cef5d-5204-4312-b3a6-6e99a4b17d7b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4c95195-5446-4642-862b-ae4b54e18926", "abb29884-46ee-4a8c-a67a-d969b805cc95", "Admin", "ADMIN" });
        }
    }
}
