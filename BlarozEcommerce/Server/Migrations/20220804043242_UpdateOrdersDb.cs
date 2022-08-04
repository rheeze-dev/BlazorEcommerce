using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlarozEcommerce.Server.Migrations
{
    public partial class UpdateOrdersDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderType",
                table: "Orders",
                newName: "OrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "OrderType");
        }
    }
}
