using Microsoft.EntityFrameworkCore.Migrations;

namespace Bi_anlasam.Migrations
{
    public partial class bianlasam2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IlanDurum",
                table: "Ilan",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IlanDurum",
                table: "Ilan",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
