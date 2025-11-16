using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaberMais.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarUsuarioIdEmCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Atualizar cursos existentes com o ID do primeiro usuário
            migrationBuilder.Sql(@"
                UPDATE Cursos 
                SET UsuarioId = (SELECT TOP 1 Id FROM Usuarios ORDER BY Id)
                WHERE UsuarioId = 0
            ");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_UsuarioId",
                table: "Cursos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Usuarios_UsuarioId",
                table: "Cursos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Usuarios_UsuarioId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_UsuarioId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Cursos");
        }
    }
}