using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBilet.Migrations
{
    public partial class eBilet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktörler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilResmiURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktörler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinemalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinemalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yapımcılar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilResmiURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapımcılar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    ResimURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaşlangıçTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitişTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmKategori = table.Column<int>(type: "int", nullable: false),
                    SinemaId = table.Column<int>(type: "int", nullable: false),
                    YapımcıId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fimler_Sinemalar_SinemaId",
                        column: x => x.SinemaId,
                        principalTable: "Sinemalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fimler_Yapımcılar_YapımcıId",
                        column: x => x.YapımcıId,
                        principalTable: "Yapımcılar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aktörler_Filmler",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    AktörId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktörler_Filmler", x => new { x.AktörId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_Aktörler_Filmler_Aktörler_AktörId",
                        column: x => x.AktörId,
                        principalTable: "Aktörler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aktörler_Filmler_Fimler_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Fimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aktörler_Filmler_FilmId",
                table: "Aktörler_Filmler",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Fimler_SinemaId",
                table: "Fimler",
                column: "SinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fimler_YapımcıId",
                table: "Fimler",
                column: "YapımcıId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktörler_Filmler");

            migrationBuilder.DropTable(
                name: "Aktörler");

            migrationBuilder.DropTable(
                name: "Fimler");

            migrationBuilder.DropTable(
                name: "Sinemalar");

            migrationBuilder.DropTable(
                name: "Yapımcılar");
        }
    }
}
