using questionario_tcc_api.Enums;


namespace questionario_tcc_api.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public int Idade { get; set; }
        public Genero Genero { get; set; }
        public StatusCivil StatusCivil { get; set; }
        public Etinia Etnia { get; set; }
        public bool DoencaCronica { get; set; }
        public string QualDoenca { get; set; } = string.Empty;
        public HorasExercicios HoraExercicio { get; set; }
        public bool MedicamentoContinuo { get; set; }
        public string QualMedicamento { get; set; } = string.Empty;
        public int MlCafeSemana { get; set; }
        public bool Fuma { get; set; }
        public int QtdMacosSemana { get; set; }
        public bool Bebida { get; set; }
        public int BedidasSemana { get; set; }
        public AnosCafeleia AnosCafeleia { get; set; }
        public int EpisodiosMes { get; set; }
        public bool BuscaProficional { get; set; }
        public bool Melhora { get; set; }
        public double LocalDorX { get; set; }
        public double LocalDorY { get; set; }
        public double LocalMaiorDorX { get; set; }
        public double LocalMaiorDorY { get; set; }
        public int MaiorDor24h { get; set; }
        public int MenorDor24h { get; set; }
        public int GeralDor24h { get; set; }
        public int DorMomento { get; set; }
        public string TratamentoDor { get; set; } = string.Empty;
        public int DorAtividadeGeral { get; set; }
        public int DorHumor { get; set; }
        public int DorLocomocao { get; set; }
        public int DorTrabalho { get; set; }
        public int DorRelacionamento { get; set; }
        public int DorSono { get; set; }
        public int DorVida { get; set; }
        public LocalExataDor LocalExataDor { get; set; }
        public bool DorIrradia { get; set; }
        public double LocalIrradiaDorX { get; set; }
        public double LocalIrradiaDorY { get; set; }
        public string DiscriçãoDor { get; set; } = string.Empty;
        public int ItensidadeDor { get; set; }
        public string TempoPicoDor { get; set; } = DateTime.Now.ToString("HH:mm");
        public string TempoCrise { get; set; } = DateTime.Now.ToString("HH:mm");
        public bool FatorAgravante { get; set; }
        public string QualFatorAgravante { get; set; } = string.Empty;
        public bool FatorAtenuante { get; set; }
        public string QualFatorAtenuante { get; set; } = string.Empty;
        public bool SintomasAlem { get; set; }
        public string QualSintomasAlem { get; set; } = string.Empty;
    }
}
