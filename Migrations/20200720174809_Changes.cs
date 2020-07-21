using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LineChartData",
                table: "LineChartData");

            migrationBuilder.RenameTable(
                name: "LineChartData",
                newName: "LineChart");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "LineChart",
                newName: "TimeStamp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineChart",
                table: "LineChart",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LineChart",
                table: "LineChart");

            migrationBuilder.RenameTable(
                name: "LineChart",
                newName: "LineChartData");

            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "LineChartData",
                newName: "Timestamp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineChartData",
                table: "LineChartData",
                column: "Id");
        }
    }
}
