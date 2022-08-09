using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2ND_Backend_Exam.DATA.Migrations
{
    public partial class ColumnTypeDate02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2022, 8, 9, 12, 38, 28, 468, DateTimeKind.Local).AddTicks(9469));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2022, 8, 9, 12, 35, 0, 411, DateTimeKind.Local).AddTicks(9645));
        }
    }
}
