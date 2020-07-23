using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class CreationofActualVsPredictedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PredictedData",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    PredictedCurrent = table.Column<double>(nullable: false),
                    ExtraplatedCurrent = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictedData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PredictedData");
        }
    }
}
