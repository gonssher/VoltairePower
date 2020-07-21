using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class UpgradingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Timestamp",
                table: "LineChart",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ChartData",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    TimeStamp = table.Column<string>(nullable: true),
                    Voltage = table.Column<double>(nullable: false),
                    TranslatedVoltage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChartData");

            migrationBuilder.AlterColumn<string>(
                name: "Timestamp",
                table: "LineChart",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
