using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventosAca.API.Migrations
{
    /// <inheritdoc />
    public partial class Csaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos");

            migrationBuilder.RenameTable(
                name: "Eventos",
                newName: "eventos");

            migrationBuilder.AddColumn<int>(
                name: "AcademicoId",
                table: "eventos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "eventos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fechaInicio",
                table: "eventos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fechaOut",
                table: "eventos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ubicacion",
                table: "eventos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventos",
                table: "eventos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "participante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "programaEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoAcademicoId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreSesion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombreponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AfiliacionInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programaEventos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "participante");

            migrationBuilder.DropTable(
                name: "programaEventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventos",
                table: "eventos");

            migrationBuilder.DropColumn(
                name: "AcademicoId",
                table: "eventos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "eventos");

            migrationBuilder.DropColumn(
                name: "fechaInicio",
                table: "eventos");

            migrationBuilder.DropColumn(
                name: "fechaOut",
                table: "eventos");

            migrationBuilder.DropColumn(
                name: "ubicacion",
                table: "eventos");

            migrationBuilder.RenameTable(
                name: "eventos",
                newName: "Eventos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos",
                column: "Id");
        }
    }
}
