using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCrud.Migrations
{
    /// <inheritdoc />
    public partial class UnificaClienteEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoEndereco",
                table: "Cliente",
                newName: "Tipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Cliente",
                newName: "TipoEndereco");
        }
    }
}
