using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updatingTableValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Impp",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Isc",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "NumberOfWatts",
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
                name: "Vmpp",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "Voc",
                table: "SolarSheetDetails");

            migrationBuilder.AlterColumn<double>(
                name: "InverterSize",
                table: "SolarSheetDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InverterModel",
                table: "SolarSheetDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InverterMakes",
                table: "SolarSheetDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "AcFreqNorminal",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AcOpVolt",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "AcVolt",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArrayLocation",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DcInput",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LengthOfString",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxContinuousOC",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxDc",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ModuleOpenShortCircuit",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ModulePerSeries",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ModuleShortCircuit",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ModuleTempCoeff",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PeakInvEff",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PeakPwrTv",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PowerFact",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SolarModulePwr",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TypeofWire",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WireGPerStr",
                table: "SolarSheetDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcFreqNorminal",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "AcOpVolt",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "AcVolt",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ArrayLocation",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "DcInput",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "LengthOfString",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "MaxContinuousOC",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "MaxDc",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ModuleOpenShortCircuit",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ModulePerSeries",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ModuleShortCircuit",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "ModuleTempCoeff",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "PeakInvEff",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "PeakPwrTv",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "PowerFact",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "SolarModulePwr",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "TypeofWire",
                table: "SolarSheetDetails");

            migrationBuilder.DropColumn(
                name: "WireGPerStr",
                table: "SolarSheetDetails");

            migrationBuilder.AlterColumn<int>(
                name: "InverterSize",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "InverterModel",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "InverterMakes",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Impp",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Isc",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfWatts",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SolarStringsolarConnection",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SolarStringsolarModel",
                table: "SolarSheetDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TemCoeffoicient",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vmpp",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Voc",
                table: "SolarSheetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
