using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace questionario_tcc_api.Migrations
{
    /// <inheritdoc />
    public partial class newquestionariov05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Criterio1",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio10",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio11",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio12",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio13",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio14",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio15",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio16",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio2",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio3",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio4",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio5",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio6",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio7",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio8",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Criterio9",
                table: "Paciente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Criterio1",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio10",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio11",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio12",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio13",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio14",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio15",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio16",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio2",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio3",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio4",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio5",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio6",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio7",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio8",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Criterio9",
                table: "Paciente");
        }
    }
}
