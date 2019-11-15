using Microsoft.EntityFrameworkCore.Migrations;

namespace VCDrapery.Server.Data.Migrations
{
    public partial class updatePriceToTotalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "QuoteLineItems",
                newName: "TotalPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "QuoteLineItems",
                newName: "Price");
        }
    }
}
