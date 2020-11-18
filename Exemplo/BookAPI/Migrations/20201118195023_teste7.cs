using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class teste7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "ExpectedDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LoanDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Authors",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Isbn_10",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Isbn_13",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Pagecount",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "smallThumbnail",
                table: "CurriculumVitae");

            migrationBuilder.AddColumn<DateTime>(
                name: "AdmissionDate",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ResignationDate",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Settings",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "CurriculumVitae",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "CurriculumVitae",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "CurriculumVitae",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CurriculumVitae",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdmissionDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "ResignationDate",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "CurriculumVitae");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CurriculumVitae");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Settings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedDate",
                table: "Settings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanDate",
                table: "Settings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Isbn_10",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Isbn_13",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pagecount",
                table: "CurriculumVitae",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "CurriculumVitae",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "smallThumbnail",
                table: "CurriculumVitae",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
