using Microsoft.EntityFrameworkCore.Migrations;

namespace BusApp.Dataa.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    BusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusDriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusPlaque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusSeatNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Expeditions",
                columns: table => new
                {
                    ExpeditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpeditionStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpeditionStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpeditionFinish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpeditionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpeditionHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpeditionPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expeditions", x => x.ExpeditionId);
                    table.ForeignKey(
                        name: "FK_Expeditions_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expeditions_BusId",
                table: "Expeditions",
                column: "BusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Expeditions");

            migrationBuilder.DropTable(
                name: "Buses");
        }
    }
}
