using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updatingsolrvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InverterMakes",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "InverterModel",
                table: "SolarSheetDetails");

            migrationBuilder.AddColumn<string>(
                name: "SolarModuleMake",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SolarModuleMake",
                table: "SolarSheetDetails");

            migrationBuilder.AddColumn<string>(
                name: "InverterMakes",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InverterModel",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
