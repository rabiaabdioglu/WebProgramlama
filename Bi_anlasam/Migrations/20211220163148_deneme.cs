using Microsoft.EntityFrameworkCore.Migrations;

namespace Bi_anlasam.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teklif_Kullanici_KullaniciId",
                table: "Teklif");

            migrationBuilder.DropIndex(
                name: "IX_Teklif_KullaniciId",
                table: "Teklif");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Teklif");

            migrationBuilder.AlterColumn<int>(
                name: "Fiyat",
                table: "Teklif",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Fiyat",
                table: "Teklif",
                type: "money",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Teklif",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_KullaniciId",
                table: "Teklif",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teklif_Kullanici_KullaniciId",
                table: "Teklif",
                column: "KullaniciId",
                principalTable: "Kullanici",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
