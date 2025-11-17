using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaberMais.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoRecomendado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Recomendado",
                table: "Cursos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recomendado",
                table: "Cursos");
        }
    }
}
