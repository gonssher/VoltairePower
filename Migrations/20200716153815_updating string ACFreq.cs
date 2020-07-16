using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updatingstringACFreq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaxContinuousOC",
                table: "SolarSheetDetails",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "AcFreqNorminal",
                table: "SolarSheetDetails",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MaxContinuousOC",
                table: "SolarSheetDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "AcFreqNorminal",
                table: "SolarSheetDetails",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
