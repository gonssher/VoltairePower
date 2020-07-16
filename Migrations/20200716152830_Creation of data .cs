using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class Creationofdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Wind_Direction_Degree",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Weather_Temperature_Celsius",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Weather_Relative_Humidity_Percent",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Global_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Diffuse_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Current_Phase_Average_Mean_A",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Active_Power_Kw",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Active_Energy_Delivered_Received_kWh",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Wind_Direction_Degree",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Weather_Temperature_Celsius",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Weather_Relative_Humidity_Percent",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Global_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Diffuse_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Current_Phase_Average_Mean_A",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Active_Power_Kw",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Active_Energy_Delivered_Received_kWh",
                table: "LiveDataFeed",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
