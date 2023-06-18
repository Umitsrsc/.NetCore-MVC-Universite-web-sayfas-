using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Duzce.Migrations
{
    public partial class secondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuyuruTurleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuyuruTurleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duyurular",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuyuruTuruId = table.Column<int>(nullable: false),
                    Baslık = table.Column<string>(nullable: true),
                    Icerik = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Resim = table.Column<string>(nullable: true),
                    Durum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Duyurular_DuyuruTurleri_DuyuruTuruId",
                        column: x => x.DuyuruTuruId,
                        principalTable: "DuyuruTurleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Duyurular_DuyuruTuruId",
                table: "Duyurular",
                column: "DuyuruTuruId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Duyurular");

            migrationBuilder.DropTable(
                name: "DuyuruTurleri");
        }
    }
}
