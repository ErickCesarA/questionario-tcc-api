using questionario_tcc_api.Enums;
using static System.Net.Mime.MediaTypeNames;


namespace questionario_tcc_api.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string StatusCivil { get; set; } = string.Empty;
        public string Etnia { get; set; } = string.Empty;
        public bool DoencaCronica { get; set; }
        public string QualDoenca { get; set; } = string.Empty;
        public string HoraExercicio { get; set; } = string.Empty;
        public bool MedicamentoContinuo { get; set; }
        public string QualMedicamento { get; set; } = string.Empty;
        public int MlCafeSemana { get; set; }
        public bool Fuma { get; set; }
        public int QtdMacosSemana { get; set; }
        public bool Bebida { get; set; }
        public int BedidasSemana { get; set; }
        public string AnosCafeleia { get; set; } = string.Empty;
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
        public string LocalExataDor { get; set; } = string.Empty;
        public bool DorIrradia { get; set; }
        public double LocalIrradiaDorX { get; set; }
        public double LocalIrradiaDorY { get; set; }
        public string DiscriçãoDor { get; set; } = string.Empty;
        public int ItensidadeDor { get; set; }
        public string TempoPicoDor { get; set; } = DateTime.Now.ToShortTimeString();
        public string TempoCrise { get; set; } = DateTime.Now.ToShortTimeString();
        public bool FatorAgravante { get; set; }
        public string QualFatorAgravante { get; set; } = string.Empty;
        public bool FatorAtenuante { get; set; }
        public string QualFatorAtenuante { get; set; } = string.Empty;
        public bool SintomasAlem { get; set; }
        public bool NauseaVomito { get; set; }
        public bool SensiLuzSom { get; set; }
        public bool PontBriManchEsc { get; set; }
        public bool Criterio1 { get; set; }
        public bool Criterio2 { get; set; }
        public bool Criterio3 { get; set; }
        public bool Criterio4 { get; set; }
        public bool Criterio5 { get; set; }
        public bool Criterio6 { get; set; }
        public bool Criterio7 { get; set; }
        public bool Criterio8 { get; set; }
        public bool Criterio9 { get; set; }
        public bool Criterio10 { get; set; }
        public bool Criterio11 { get; set; }
        public bool Criterio12 { get; set; }
        public bool Criterio13 { get; set; }
        public bool Criterio14 { get; set; }
        public bool Criterio15 { get; set; }
        public bool Criterio16 { get; set; }

    }
}
