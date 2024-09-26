using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimosLivraria.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recbedor",
                table: "Emprestimos",
                newName: "Recebedor");

            migrationBuilder.AddColumn<string>(
                name: "Fornecedor",
                table: "Emprestimos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fornecedor",
                table: "Emprestimos");

            migrationBuilder.RenameColumn(
                name: "Recebedor",
                table: "Emprestimos",
                newName: "Recbedor");
        }
    }
}
