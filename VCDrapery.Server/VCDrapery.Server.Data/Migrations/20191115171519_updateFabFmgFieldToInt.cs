using Microsoft.EntityFrameworkCore.Migrations;

namespace VCDrapery.Server.Data.Migrations
{
    public partial class updateFabFmgFieldToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FabricFabFmg",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FabricFabFmg",
                table: "QuoteLineItems",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
