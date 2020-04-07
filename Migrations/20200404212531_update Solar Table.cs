using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updateSolarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CableConnector",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "InstalledDate",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "MaxPower",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ModuleEffeciency",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "OperatingTemperature",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "OperatingVoltage",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "SolarType",
                table: "SolarSheetDetails");

            migrationBuilder.AddColumn<int>(
                name: "Impp",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InverterMakes",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InverterModel",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InverterSize",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Isc",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSolarStrings",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfWatts",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberofInverters",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SolarSize",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SolarStringsolarConnection",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SolarStringsolarModel",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TemCoeffoicient",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vmpp",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Voc",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Impp",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "InverterMakes",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "InverterModel",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "InverterSize",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Isc",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "NumberOfSolarStrings",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "NumberOfWatts",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "NumberofInverters",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "SolarSize",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "SolarStringsolarConnection",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "SolarStringsolarModel",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "TemCoeffoicient",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Vmpp",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Voc",
                table: "SolarSheetDetails");

            migrationBuilder.AddColumn<string>(
                name: "CableConnector",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InstalledDate",
                table: "SolarSheetDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MaxPower",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModuleEffeciency",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingTemperature",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingVoltage",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SolarType",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
