using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class ChangetoWeatherDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WeatherData",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "WeatherData",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "WeatherData");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WeatherData",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherData",
                table: "WeatherData",
                column: "Name");
        }
    }
}
