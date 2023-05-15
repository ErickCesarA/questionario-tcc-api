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
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    StatusCivil = table.Column<int>(type: "int", nullable: false),
                    Etnia = table.Column<int>(type: "int", nullable: false),
                    DoencaCronica = table.Column<bool>(type: "bit", nullable: false),
                    QualDoenca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraExercicio = table.Column<int>(type: "int", nullable: false),
                    MedicamentoContinuo = table.Column<bool>(type: "bit", nullable: false),
                    QualMedicamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MlCafeSemana = table.Column<int>(type: "int", nullable: false),
                    Fuma = table.Column<bool>(type: "bit", nullable: false),
                    QtdMacosSemana = table.Column<int>(type: "int", nullable: false),
                    Bebida = table.Column<bool>(type: "bit", nullable: false),
                    BedidasSemana = table.Column<int>(type: "int", nullable: false),
                    AnosCafeleia = table.Column<int>(type: "int", nullable: false),
                    EpisodiosMes = table.Column<int>(type: "int", nullable: false),
                    BuscaProficional = table.Column<bool>(type: "bit", nullable: false),
                    Melhora = table.Column<bool>(type: "bit", nullable: false),
                    LocalDorX = table.Column<double>(type: "float", nullable: false),
                    LocalDorY = table.Column<double>(type: "float", nullable: false),
                    LocalMaiorDorX = table.Column<double>(type: "float", nullable: false),
                    LocalMaiorDorY = table.Column<double>(type: "float", nullable: false),
                    MaiorDor24h = table.Column<int>(type: "int", nullable: false),
                    MenorDor24h = table.Column<int>(type: "int", nullable: false),
                    GeralDor24h = table.Column<int>(type: "int", nullable: false),
                    DorMomento = table.Column<int>(type: "int", nullable: false),
                    TratamentoDor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DorAtividadeGeral = table.Column<int>(type: "int", nullable: false),
                    DorHumor = table.Column<int>(type: "int", nullable: false),
                    DorLocomocao = table.Column<int>(type: "int", nullable: false),
                    DorTrabalho = table.Column<int>(type: "int", nullable: false),
                    DorRelacionamento = table.Column<int>(type: "int", nullable: false),
                    DorSono = table.Column<int>(type: "int", nullable: false),
                    DorVida = table.Column<int>(type: "int", nullable: false),
                    LocalExataDor = table.Column<int>(type: "int", nullable: false),
                    DorIrradia = table.Column<bool>(type: "bit", nullable: false),
                    LocalIrradiaDorX = table.Column<double>(type: "float", nullable: false),
                    LocalIrradiaDorY = table.Column<double>(type: "float", nullable: false),
                    DiscriçãoDor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItensidadeDor = table.Column<int>(type: "int", nullable: false),
                    TempoPicoDor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoCrise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatorAgravante = table.Column<bool>(type: "bit", nullable: false),
                    QualFatorAgravante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatorAtenuante = table.Column<bool>(type: "bit", nullable: false),
                    QualFatorAtenuante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SintomasAlem = table.Column<bool>(type: "bit", nullable: false),
                    NauseaVomito = table.Column<bool>(type: "bit", nullable: false),
                    SensiLuzSom = table.Column<bool>(type: "bit", nullable: false),
                    PontBriManchEsc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
