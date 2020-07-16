using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class Creationofdatasets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Wind_Direction_Degree",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Weather_Temperature_Celsius",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Weather_Relative_Humidity_Percent",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Global_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Diffuse_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Current_Phase_Average_Mean_A",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Active_Power_Kw",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Active_Energy_Delivered_Received_kWh",
                table: "LiveDataFeed",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Wind_Direction_Degree",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Weather_Temperature_Celsius",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Weather_Relative_Humidity_Percent",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Global_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Diffuse_Horizontal_Radiation_WM2",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Current_Phase_Average_Mean_A",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Active_Power_Kw",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Active_Energy_Delivered_Received_kWh",
                table: "LiveDataFeed",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
