using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2ND_Backend_Exam.DATA.Migrations
{
    public partial class builder03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "EduMaterials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "EduMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
