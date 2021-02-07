using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetReserve.Migrations
{
    public partial class VetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientCardModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsIll = table.Column<bool>(type: "bit", nullable: false),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dose = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCardModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VetModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VetSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VetModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VetSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientCardModel");

            migrationBuilder.DropTable(
                name: "VetModel");

            migrationBuilder.DropTable(
                name: "VisitModel");
        }
    }
}
