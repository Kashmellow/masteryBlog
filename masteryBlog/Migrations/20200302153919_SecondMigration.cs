using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace masteryBlog.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "PublishDate", "Title" },
                values: new object[] { "lilmama1037", "Kids make the craziest faces when they poop", new DateTime(2020, 3, 2, 10, 39, 18, 562, DateTimeKind.Local).AddTicks(5206), "Pooping Faces" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "PublishDate", "Title" },
                values: new object[] { "BigZaddy", "Tips on sleeping when your kids seem like they wont", new DateTime(2020, 3, 2, 10, 39, 18, 565, DateTimeKind.Local).AddTicks(6110), "Gettin sleep" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Content", "PublishDate", "Title" },
                values: new object[] { "Svetlana", "Here's some content about parenting", new DateTime(2020, 3, 1, 22, 32, 3, 532, DateTimeKind.Local).AddTicks(3480), "First Blog" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Content", "PublishDate", "Title" },
                values: new object[] { "Viktor", "Here's some more content about parenting", new DateTime(2020, 3, 1, 22, 32, 3, 534, DateTimeKind.Local).AddTicks(4048), "Second Blog" });
        }
    }
}
