using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class Updatngmydbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "LineChart",
                newName: "Timestamp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "LineChart",
                newName: "TimeStamp");
        }
    }
}
