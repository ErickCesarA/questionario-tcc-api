using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace questionario_tcc_api.Migrations
{
    /// <inheritdoc />
    public partial class newquestionariov06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LocalMaiorDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "LocalMaiorDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "LocalIrradiaDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "LocalIrradiaDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "LocalDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "LocalDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalIrradiaDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalIrradiaDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalMaiorDorX",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelaLocalMaiorDorY",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelaLocalDorX",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TelaLocalDorY",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TelaLocalIrradiaDorX",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TelaLocalIrradiaDorY",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TelaLocalMaiorDorX",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TelaLocalMaiorDorY",
                table: "Paciente");

            migrationBuilder.AlterColumn<double>(
                name: "LocalMaiorDorY",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "LocalMaiorDorX",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "LocalIrradiaDorY",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "LocalIrradiaDorX",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "LocalDorY",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "LocalDorX",
                table: "Paciente",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
