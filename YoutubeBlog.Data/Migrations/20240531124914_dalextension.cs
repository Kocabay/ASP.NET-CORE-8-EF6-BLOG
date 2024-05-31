using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class dalextension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5a3b1151-55c9-49d2-8bb2-ef27ce37d1fb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ab1dae6a-5cf6-450e-a667-37a51a19abf8"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("aa8fdb81-e73b-4470-9343-ba2d8eb04efb"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh...", "Admin Test", new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(3202), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("f125fb07-3167-4dfb-b4fb-ed0484f43614"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh.  ", "Admin Test", new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(3187), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 31, 15, 49, 13, 959, DateTimeKind.Local).AddTicks(5452));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("aa8fdb81-e73b-4470-9343-ba2d8eb04efb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f125fb07-3167-4dfb-b4fb-ed0484f43614"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5a3b1151-55c9-49d2-8bb2-ef27ce37d1fb"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh...", "Admin Test", new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(4706), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("ab1dae6a-5cf6-450e-a667-37a51a19abf8"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh.  ", "Admin Test", new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(4699), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 16, 58, 45, 380, DateTimeKind.Local).AddTicks(6969));
        }
    }
}
