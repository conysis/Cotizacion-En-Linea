using Microsoft.EntityFrameworkCore.Migrations;

namespace CotizLicitAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licitacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expediente = table.Column<string>(type: "nvarchar(9)", nullable: false),
                    FecCreacion = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    FecApertura = table.Column<string>(type: "nvarchar(10)", nullable: true),
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
