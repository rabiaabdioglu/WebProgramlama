using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bi_anlasam.Migrations
{
    public partial class bianlasam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alan",
                columns: table => new
                {
                    AlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlanAd = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alan", x => x.AlanId);
                });

            migrationBuilder.CreateTable(
                name: "Sehir",
                columns: table => new
                {
                    SehirId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehir", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Universite",
                columns: table => new
                {
                    UniversiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversiteAd = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universite", x => x.UniversiteId);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    DersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(maxLength: 80, nullable: true),
                    AlanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.DersId);
                    table.ForeignKey(
                        name: "FK_Ders_Alan_AlanId",
                        column: x => x.AlanId,
                        principalTable: "Alan",
                        principalColumn: "AlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: true),
                    Soyadi = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    Telefon = table.Column<int>(nullable: false),
                    KullaniciPuani = table.Column<int>(nullable: false),
                    HesapDurum = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    UniversiteId = table.Column<int>(nullable: false),
                    BolumAdi = table.Column<string>(nullable: true),
                    SehirId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciId);
                    table.ForeignKey(
                        name: "FK_Kullanici_Sehir_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehir",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanici_Universite_UniversiteId",
                        column: x => x.UniversiteId,
                        principalTable: "Universite",
                        principalColumn: "UniversiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilan",
                columns: table => new
                {
                    IlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanTarihi = table.Column<DateTime>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    DersId = table.Column<int>(nullable: false),
                    Baslik = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    IlanDurum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilan", x => x.IlanId);
                    table.ForeignKey(
                        name: "FK_Ilan_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilan_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teklif",
                columns: table => new
                {
                    TeklifId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: true),
                    TeklifVerenKullaniciId = table.Column<int>(nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teklif", x => x.TeklifId);
                    table.ForeignKey(
                        name: "FK_Teklif_Ilan_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilan",
                        principalColumn: "IlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teklif_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bulusma",
                columns: table => new
                {
                    BulusmaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puan = table.Column<int>(nullable: false),
                    Yorum = table.Column<string>(nullable: true),
                    BulusmaTarihi = table.Column<DateTime>(nullable: false),
                    TeklifId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulusma", x => x.BulusmaId);
                    table.ForeignKey(
                        name: "FK_Bulusma_Teklif_TeklifId",
                        column: x => x.TeklifId,
                        principalTable: "Teklif",
                        principalColumn: "TeklifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bulusma_TeklifId",
                table: "Bulusma",
                column: "TeklifId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_AlanId",
                table: "Ders",
                column: "AlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_DersId",
                table: "Ilan",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilan_KullaniciId",
                table: "Ilan",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_SehirId",
                table: "Kullanici",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_UniversiteId",
                table: "Kullanici",
                column: "UniversiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_IlanId",
                table: "Teklif",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Teklif_KullaniciId",
                table: "Teklif",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bulusma");

            migrationBuilder.DropTable(
                name: "Teklif");

            migrationBuilder.DropTable(
                name: "Ilan");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Alan");

            migrationBuilder.DropTable(
                name: "Sehir");

            migrationBuilder.DropTable(
                name: "Universite");
        }
    }
}
