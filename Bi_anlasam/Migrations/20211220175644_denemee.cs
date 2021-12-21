using Microsoft.EntityFrameworkCore.Migrations;

namespace Bi_anlasam.Migrations
{
    public partial class denemee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "Ilan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "Ilan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    IlceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAd = table.Column<int>(nullable: false),
                    SehirId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.IlceId);
                    table.ForeignKey(
                        name: "FK_Ilce_Sehir_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehir",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_IlceId",
                table: "Ilan",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_SehirId",
                table: "Ilce",
                column: "SehirId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ilan_Ilce_IlceId",
                table: "Ilan",
                column: "IlceId",
                principalTable: "Ilce",
                principalColumn: "IlceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ilan_Ilce_IlceId",
                table: "Ilan");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropIndex(
                name: "IX_Ilan_IlceId",
                table: "Ilan");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Ilan");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "Ilan");
        }
    }
}
