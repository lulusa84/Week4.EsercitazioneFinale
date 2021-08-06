using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week4.EsercitazioneFinale.EFLib.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodiceCliente = table.Column<string>(maxLength: 20, nullable: false),
                    NomeCl = table.Column<string>(maxLength: 50, nullable: false),
                    CognomeCl = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Ordine",
                columns: table => new
                {
                    OrdineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOrd = table.Column<DateTime>(maxLength: 50, nullable: false),
                    CodiceOrdine = table.Column<string>(maxLength: 20, nullable: false),
                    CodiceProd = table.Column<string>(maxLength: 50, nullable: false),
                    Importo = table.Column<decimal>(maxLength: 50, nullable: false),
                    ClienteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordine", x => x.OrdineID);
                    table.ForeignKey(
                        name: "FK_Ordine_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ordine_ClienteID",
                table: "Ordine",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ordine");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
