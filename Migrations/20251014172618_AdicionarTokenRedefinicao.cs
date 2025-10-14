using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaberMais.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTokenRedefinicao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TokenRedefinicao",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenValidade",
                table: "Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TokenRedefinicao",
                table: "Administradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenValidade",
                table: "Administradores",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenRedefinicao",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TokenValidade",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TokenRedefinicao",
                table: "Administradores");

            migrationBuilder.DropColumn(
                name: "TokenValidade",
                table: "Administradores");
        }
    }
}
