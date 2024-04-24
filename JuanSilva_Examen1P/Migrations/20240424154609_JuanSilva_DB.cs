using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanSilva_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class JuanSilva_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JS_producto",
                columns: table => new
                {
                    JsProductoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JsnumeroSerie = table.Column<int>(type: "int", nullable: false),
                    Jsprecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JsNombreProducto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    JsDisponible = table.Column<bool>(type: "bit", nullable: false),
                    JsFechaAgregado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JS_producto", x => x.JsProductoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JS_producto");
        }
    }
}
