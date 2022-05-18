using Microsoft.EntityFrameworkCore.Migrations;

namespace BusApp.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoltukNo = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletId);
                });

            migrationBuilder.CreateTable(
                name: "Guzergahs",
                columns: table => new
                {
                    GuzergahId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslangıc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gz1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gz2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bitis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guzergahs", x => x.GuzergahId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "BiletGuzergah",
                columns: table => new
                {
                    BiletsBiletId = table.Column<int>(type: "int", nullable: false),
                    GuzergahsGuzergahId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiletGuzergah", x => new { x.BiletsBiletId, x.GuzergahsGuzergahId });
                    table.ForeignKey(
                        name: "FK_BiletGuzergah_Bilets_BiletsBiletId",
                        column: x => x.BiletsBiletId,
                        principalTable: "Bilets",
                        principalColumn: "BiletId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiletGuzergah_Guzergahs_GuzergahsGuzergahId",
                        column: x => x.GuzergahsGuzergahId,
                        principalTable: "Guzergahs",
                        principalColumn: "GuzergahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiletGuzergah_GuzergahsGuzergahId",
                table: "BiletGuzergah",
                column: "GuzergahsGuzergahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiletGuzergah");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Guzergahs");
        }
    }
}
