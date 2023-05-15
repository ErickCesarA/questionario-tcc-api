using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace questionario_tcc_api.Migrations
{
    /// <inheritdoc />
    public partial class newquestionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    StatusCivil = table.Column<int>(type: "int", nullable: false),
                    Etnia = table.Column<int>(type: "int", nullable: false),
                    DoencaCronica = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QualDoenca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoraExercicio = table.Column<int>(type: "int", nullable: false),
                    MedicamentoContinuo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QualMedicamento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MlCafeSemana = table.Column<int>(type: "int", nullable: false),
                    Fuma = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QtdMacosSemana = table.Column<int>(type: "int", nullable: false),
                    Bebida = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BedidasSemana = table.Column<int>(type: "int", nullable: false),
                    AnosCafeleia = table.Column<int>(type: "int", nullable: false),
                    EpisodiosMes = table.Column<int>(type: "int", nullable: false),
                    BuscaProficional = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Melhora = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LocalDorX = table.Column<double>(type: "double", nullable: false),
                    LocalDorY = table.Column<double>(type: "double", nullable: false),
                    LocalMaiorDorX = table.Column<double>(type: "double", nullable: false),
                    LocalMaiorDorY = table.Column<double>(type: "double", nullable: false),
                    MaiorDor24h = table.Column<int>(type: "int", nullable: false),
                    MenorDor24h = table.Column<int>(type: "int", nullable: false),
                    GeralDor24h = table.Column<int>(type: "int", nullable: false),
                    DorMomento = table.Column<int>(type: "int", nullable: false),
                    TratamentoDor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DorAtividadeGeral = table.Column<int>(type: "int", nullable: false),
                    DorHumor = table.Column<int>(type: "int", nullable: false),
                    DorLocomocao = table.Column<int>(type: "int", nullable: false),
                    DorTrabalho = table.Column<int>(type: "int", nullable: false),
                    DorRelacionamento = table.Column<int>(type: "int", nullable: false),
                    DorSono = table.Column<int>(type: "int", nullable: false),
                    DorVida = table.Column<int>(type: "int", nullable: false),
                    LocalExataDor = table.Column<int>(type: "int", nullable: false),
                    DorIrradia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LocalIrradiaDorX = table.Column<double>(type: "double", nullable: false),
                    LocalIrradiaDorY = table.Column<double>(type: "double", nullable: false),
                    DiscriçãoDor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItensidadeDor = table.Column<int>(type: "int", nullable: false),
                    TempoPicoDor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TempoCrise = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FatorAgravante = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QualFatorAgravante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FatorAtenuante = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QualFatorAtenuante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SintomasAlem = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NauseaVomito = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SensiLuzSom = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PontBriManchEsc = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
