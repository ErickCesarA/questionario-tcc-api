using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace questionario_tcc_api.Migrations
{
    /// <inheritdoc />
    public partial class newquestionariov02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Paciente",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Paciente");
        }
    }
}
