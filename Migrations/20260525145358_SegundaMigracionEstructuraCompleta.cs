using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracionEstructuraCompleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Enunciado",
                table: "Pregunta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Respuesta",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    enunciado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pregunta_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuesta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Respuesta_Pregunta_pregunta_Id",
                        column: x => x.pregunta_Id,
                        principalTable: "Pregunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_pregunta_Id",
                table: "Respuesta",
                column: "pregunta_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Respuesta");

            migrationBuilder.AlterColumn<string>(
                name: "Enunciado",
                table: "Pregunta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
