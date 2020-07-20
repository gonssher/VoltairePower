using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updatinglinegraph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LineChartData",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Voltage = table.Column<double>(nullable: false),
                    TranslatedVoltage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineChartData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineChartData");
        }
    }
}
