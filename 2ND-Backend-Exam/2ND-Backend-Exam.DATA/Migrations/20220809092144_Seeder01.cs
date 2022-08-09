using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2ND_Backend_Exam.DATA.Migrations
{
    public partial class Seeder01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Very old one Author", "Author01" },
                    { 2, "Very young one Author", "Author02" },
                    { 3, "Middle one Author", "Author03" },
                    { 4, "Some no name working for Mexico government", "Corpo" }
                });

            migrationBuilder.InsertData(
                table: "MaterialTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "YouTube" },
                    { 2, "Article" },
                    { 3, "Book" },
                    { 4, "Boot camp" },
                    { 5, "Meet up" }
                });

            migrationBuilder.InsertData(
                table: "EduMaterials",
                columns: new[] { "Id", "AuthorId", "Description", "Location", "MaterialTypeId", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Step By Step How To Step", "yt.com/aaaaaa", 1, new DateTime(2022, 8, 9, 11, 21, 44, 635, DateTimeKind.Local).AddTicks(1160), "Step By Step How To Step" },
                    { 2, 2, "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", "yt.com/bbbbbb", 1, new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "bbbbbbbbbbbbbbbbbb" },
                    { 3, 2, "ccccccccccccccccccccccccccccccccccccccccccccccc", "yt.com/ccccccccccccccccccccccccccccccccccccc", 1, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ccccccccccccccccccccccccc" },
                    { 4, 1, "some some soem", "onet.pl/some", 2, new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "some" },
                    { 5, 3, "Book Book Book Book Book Book Book ", "ISBN:00000000-0000-0000-0000-000000000000", 3, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book " },
                    { 6, 2, "Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book ", "Other Book in library", 3, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Other Book " }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "EduMaterialId", "NameOfAuthor", "Rate" },
                values: new object[,]
                {
                    { 1, "Very good", 1, "Bartek", 3 },
                    { 2, "Very bad", 1, "Slawek", 7 },
                    { 3, "IDK", 1, "Bartlomiej", 8 },
                    { 4, "Czadowo", 1, "Smok wawelski", 10 },
                    { 5, "To byl on", 2, "Kon na bialym rycerzu", 2 },
                    { 6, "Jako tako", 2, "Jaki typ", 3 },
                    { 7, "Very good", 2, "Bartek", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EduMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
