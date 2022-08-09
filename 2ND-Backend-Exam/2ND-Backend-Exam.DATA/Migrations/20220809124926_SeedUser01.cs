using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2ND_Backend_Exam.DATA.Migrations
{
    public partial class SeedUser01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2022, 8, 9, 14, 49, 26, 57, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 1, "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 2, "04F8996DA763B7A969B1028EE3007569EAF3A635486DDAB211D512C85B9DF8FB", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2022, 8, 9, 12, 38, 28, 468, DateTimeKind.Local).AddTicks(9469));
        }
    }
}
