using Microsoft.EntityFrameworkCore.Migrations;

namespace VCDrapery.Server.Data.Migrations
{
    public partial class updateIntsToDecimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Yards",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "WidthsLab",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Widths",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "RodSize",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Return",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "FabricLength",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "FabricFullness",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "FabricFabFmg",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Yards",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "WidthsLab",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Widths",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "RodSize",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Return",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "FabricLength",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "FabricFullness",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "FabricFabFmg",
                table: "QuoteLineItems",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
