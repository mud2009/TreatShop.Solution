using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatShop.Migrations
{
    public partial class ChangeFlavorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Flavors",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Flavors",
                newName: "Description");
        }
    }
}
