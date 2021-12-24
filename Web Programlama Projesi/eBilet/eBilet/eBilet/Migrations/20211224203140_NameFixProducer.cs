using Microsoft.EntityFrameworkCore.Migrations;

namespace eBilet.Migrations
{
    public partial class NameFixProducer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmler_Yapımcılar_YapımcıId",
                table: "Filmler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yapımcılar",
                table: "Yapımcılar");

            migrationBuilder.RenameTable(
                name: "Yapımcılar",
                newName: "Yapımcılar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yapımcılar",
                table: "Yapımcılar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmler_Yapımcılar_YapımcıId",
                table: "Filmler",
                column: "YapımcıId",
                principalTable: "Yapımcılar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmer_Yapımcılar_YapımcıId",
                table: "Filmler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yapımcılar",
                table: "Yapımcılar");

            migrationBuilder.RenameTable(
                name: "Yapımcılar",
                newName: "Yapımcılar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yapımcılar",
                table: "Yapımcılar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmler_Yapımcılar_YapımcıId",
                table: "Filmler",
                column: "YapımcıId",
                principalTable: "Yapımcılar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
