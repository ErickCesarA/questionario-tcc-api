using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using questionario_tcc_api.Models;


namespace questionario_tcc_api.Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<PacienteModel>
    {
        public void Configure(EntityTypeBuilder<PacienteModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Idade);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.StatusCivil);
            builder.Property(x => x.Etnia);
            builder.Property(x => x.DoencaCronica);
            builder.Property(x => x.QualDoenca);
            builder.Property(x => x.HoraExercicio);
            builder.Property(x => x.MedicamentoContinuo);
            builder.Property(x => x.QualMedicamento);
            builder.Property(x => x.MlCafeSemana);
            builder.Property(x => x.Fuma);
            builder.Property(x => x.QtdMacosSemana);
            builder.Property(x => x.Bebida);
            builder.Property(x => x.BedidasSemana);
            builder.Property(x => x.AnosCafeleia);
            builder.Property(x => x.EpisodiosMes);
            builder.Property(x => x.BuscaProficional);
            builder.Property(x => x.Melhora);
            builder.Property(x => x.LocalDorX);
            builder.Property(x => x.LocalDorY);
            builder.Property(x => x.TelaLocalDorX);
            builder.Property(x => x.TelaLocalDorY);
            builder.Property(x => x.LocalMaiorDorX);
            builder.Property(x => x.LocalMaiorDorY);
            builder.Property(x => x.TelaLocalMaiorDorX);
            builder.Property(x => x.TelaLocalMaiorDorY);
            builder.Property(x => x.MaiorDor24h);
            builder.Property(x => x.MenorDor24h);
            builder.Property(x => x.GeralDor24h);
            builder.Property(x => x.DorMomento);
            builder.Property(x => x.TratamentoDor);
            builder.Property(x => x.DorAtividadeGeral);
            builder.Property(x => x.DorHumor);
            builder.Property(x => x.DorLocomocao);
            builder.Property(x => x.DorTrabalho);
            builder.Property(x => x.DorRelacionamento);
            builder.Property(x => x.DorSono);
            builder.Property(x => x.DorVida);
            builder.Property(x => x.LocalExataDor);
            builder.Property(x => x.DorIrradia);
            builder.Property(x => x.LocalIrradiaDorX);
            builder.Property(x => x.LocalIrradiaDorY);
            builder.Property(x => x.TelaLocalIrradiaDorX);
            builder.Property(x => x.TelaLocalIrradiaDorY);
            builder.Property(x => x.DiscriçãoDor);
            builder.Property(x => x.ItensidadeDor);
            builder.Property(x => x.TempoPicoDor);
            builder.Property(x => x.TempoCrise);
            builder.Property(x => x.FatorAgravante);
            builder.Property(x => x.QualFatorAgravante);
            builder.Property(x => x.FatorAtenuante);
            builder.Property(x => x.QualFatorAtenuante);    
            builder.Property(x => x.SintomasAlem);
            builder.Property(x => x.NauseaVomito);
            builder.Property(x => x.SensiLuzSom);
            builder.Property(x => x.PontBriManchEsc);
            builder.Property(x => x.Criterio1);
            builder.Property(x => x.Criterio2);
            builder.Property(x => x.Criterio3);
            builder.Property(x => x.Criterio4);
            builder.Property(x => x.Criterio5);
            builder.Property(x => x.Criterio6);
            builder.Property(x => x.Criterio7);
            builder.Property(x => x.Criterio8);
            builder.Property(x => x.Criterio9);
            builder.Property(x => x.Criterio10);
            builder.Property(x => x.Criterio11);
            builder.Property(x => x.Criterio12);
            builder.Property(x => x.Criterio13);
            builder.Property(x => x.Criterio14);
            builder.Property(x => x.Criterio15);
            builder.Property(x => x.Criterio16);
        }
    }
}
