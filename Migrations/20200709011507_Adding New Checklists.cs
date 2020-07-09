using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class AddingNewChecklists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ac_out = table.Column<bool>(nullable: false),
                    energy_prod = table.Column<bool>(nullable: false),
                    inspect_panel = table.Column<bool>(nullable: false),
                    shading_issue = table.Column<bool>(nullable: false),
                    panel_clean = table.Column<bool>(nullable: false),
                    inspect_array_mount = table.Column<bool>(nullable: false),
                    array_tilt = table.Column<bool>(nullable: false),
                    charge_ctrl_settings = table.Column<bool>(nullable: false),
                    battery_test = table.Column<bool>(nullable: false),
                    clean_elect_equipment = table.Column<bool>(nullable: false),
                    monitor_volt_current = table.Column<bool>(nullable: false),
                    Mac_out = table.Column<bool>(nullable: false),
                    Menergy_prod = table.Column<bool>(nullable: false),
                    Minspect_panel = table.Column<bool>(nullable: false),
                    Mshading_issue = table.Column<bool>(nullable: false),
                    Mpanel_clean = table.Column<bool>(nullable: false),
                    Minspect_array_mount = table.Column<bool>(nullable: false),
                    Marray_tilt = table.Column<bool>(nullable: false),
                    Mcharge_ctrl_settings = table.Column<bool>(nullable: false),
                    Mbattery_test = table.Column<bool>(nullable: false),
                    Mclean_elect_equipment = table.Column<bool>(nullable: false),
                    Mmonitor_volt_current = table.Column<bool>(nullable: false),
                    Sac_out = table.Column<bool>(nullable: false),
                    Senergy_prod = table.Column<bool>(nullable: false),
                    Sinspect_panel = table.Column<bool>(nullable: false),
                    Sshading_issue = table.Column<bool>(nullable: false),
                    Spanel_clean = table.Column<bool>(nullable: false),
                    Sinspect_array_mount = table.Column<bool>(nullable: false),
                    Sarray_tilt = table.Column<bool>(nullable: false),
                    Scharge_ctrl_settings = table.Column<bool>(nullable: false),
                    Sbattery_test = table.Column<bool>(nullable: false),
                    Sclean_elect_equipment = table.Column<bool>(nullable: false),
                    Smonitor_volt_current = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckLists");
        }
    }
}
