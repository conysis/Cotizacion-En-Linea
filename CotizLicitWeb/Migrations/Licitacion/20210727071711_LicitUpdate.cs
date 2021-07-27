using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CotizLicitWeb.Migrations.Licitacion
{
    public partial class LicitUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licitacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expediente = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    FecCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FecApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licitacions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Licitacions");
        }
    }
}
