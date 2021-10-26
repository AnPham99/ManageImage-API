using Microsoft.EntityFrameworkCore.Migrations;

namespace WebManageImage.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42ba2992-fd4e-4114-89f7-44b498f0541e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c5e84c1-bcbc-4df8-9eda-124620b0e26a");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "020d8718-62c6-4e05-b818-cc50ce86fa5b", "8312d8e5-2ff2-4e32-8cca-56aa007f4d70", "User", "USER" },
                    { "3d1d9e5a-c4ca-41ad-992c-0e55511c6bc9", "7ad0c1cf-d793-4d64-b692-5a019c843a6d", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "CommentCount", "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "020d8718-62c6-4e05-b818-cc50ce86fa5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1d9e5a-c4ca-41ad-992c-0e55511c6bc9");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42ba2992-fd4e-4114-89f7-44b498f0541e", "fbe6d1f8-b41a-4b02-a53e-7d79bde09403", "User", "USER" },
                    { "9c5e84c1-bcbc-4df8-9eda-124620b0e26a", "dd3a3005-6680-4a08-954c-62d8b86d85ef", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 48, 61 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 24, 36 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 46, 55 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "CommentCount", "LikeCount", "ViewsCount" },
                values: new object[] { 5, 109, 111 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 27, 37 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 23, 732 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 54, 77 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 299, 78 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 88, 134 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 18, 72 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "LikeCount", "ViewsCount" },
                values: new object[] { 30, 45 });
        }
    }
}
