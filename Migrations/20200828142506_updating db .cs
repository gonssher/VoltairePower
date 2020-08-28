using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class updatingdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "UnplannedEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UnplannedEvent_CustomerID",
                table: "UnplannedEvent",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_UnplannedEvent_Customers_CustomerID",
                table: "UnplannedEvent",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnplannedEvent_Customers_CustomerID",
                table: "UnplannedEvent");

            migrationBuilder.DropIndex(
                name: "IX_UnplannedEvent_CustomerID",
                table: "UnplannedEvent");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "UnplannedEvent");
        }
    }
}
