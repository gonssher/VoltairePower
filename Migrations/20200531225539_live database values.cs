using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class livedatabasevalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LiveDataFeed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<int>(nullable: false),
                    Current_Phase_Average_Mean_A = table.Column<int>(nullable: false),
                    Active_Energy_Delivered_Received_kWh = table.Column<int>(nullable: false),
                    Active_Power_Kw = table.Column<int>(nullable: false),
                    Weather_Temperature_Celsius = table.Column<int>(nullable: false),
                    Weather_Relative_Humidity_Percent = table.Column<int>(nullable: false),
                    Global_Horizontal_Radiation_WM2 = table.Column<int>(nullable: false),
                    Diffuse_Horizontal_Radiation_WM2 = table.Column<int>(nullable: false),
                    Wind_Direction_Degree = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveDataFeed", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiveDataFeed");
        }
    }
}
