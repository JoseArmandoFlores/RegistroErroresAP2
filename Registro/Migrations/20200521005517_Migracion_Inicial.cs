using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Errores",
                columns: table => new
                {
                    ErrorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hallazgo = table.Column<string>(nullable: true),
                    Ruta = table.Column<string>(nullable: true),
                    Importancia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errores", x => x.ErrorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Errores");
        }
    }
}
