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
            builder.Property(x => x.Idade).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Telefone).IsRequired();
            builder.Property(x => x.StatusCivil).IsRequired();
            builder.Property(x => x.Etnia).IsRequired();
            builder.Property(x => x.DoencaCronica).IsRequired();
            builder.Property(x => x.QualDoenca);
            builder.Property(x => x.HoraExercicio).IsRequired();
            builder.Property(x => x.MedicamentoContinuo).IsRequired();
            builder.Property(x => x.QualMedicamento);
            builder.Property(x => x.MlCafeSemana).IsRequired();
            builder.Property(x => x.Fuma).IsRequired();
            builder.Property(x => x.QtdMacosSemana);
            builder.Property(x => x.Bebida).IsRequired();
            builder.Property(x => x.BedidasSemana);
            builder.Property(x => x.AnosCafeleia).IsRequired();
            builder.Property(x => x.EpisodiosMes).IsRequired();
            builder.Property(x => x.BuscaProficional).IsRequired();
            builder.Property(x => x.Melhora).IsRequired();
            builder.Property(x => x.LocalDorX).IsRequired();
            builder.Property(x => x.LocalDorY).IsRequired();
            builder.Property(x => x.LocalMaiorDorX).IsRequired();
            builder.Property(x => x.LocalMaiorDorY).IsRequired();
            builder.Property(x => x.MaiorDor24h).IsRequired();
            builder.Property(x => x.MenorDor24h).IsRequired();
            builder.Property(x => x.GeralDor24h).IsRequired();
            builder.Property(x => x.DorMomento).IsRequired();
            builder.Property(x => x.TratamentoDor).IsRequired();
            builder.Property(x => x.DorAtividadeGeral).IsRequired();
            builder.Property(x => x.DorHumor).IsRequired();
            builder.Property(x => x.DorLocomocao).IsRequired();
            builder.Property(x => x.DorTrabalho).IsRequired();
            builder.Property(x => x.DorRelacionamento).IsRequired();
            builder.Property(x => x.DorSono).IsRequired();
            builder.Property(x => x.DorVida).IsRequired();
            builder.Property(x => x.LocalExataDor).IsRequired();
            builder.Property(x => x.DorIrradia).IsRequired();
            builder.Property(x => x.LocalIrradiaDorX).IsRequired();
            builder.Property(x => x.LocalIrradiaDorY).IsRequired();
            builder.Property(x => x.DiscriçãoDor).IsRequired();
            builder.Property(x => x.ItensidadeDor).IsRequired();
            builder.Property(x => x.TempoPicoDor).IsRequired();
            builder.Property(x => x.TempoCrise).IsRequired();
            builder.Property(x => x.FatorAgravante).IsRequired();
            builder.Property(x => x.QualFatorAgravante);
            builder.Property(x => x.FatorAtenuante).IsRequired();
            builder.Property(x => x.QualFatorAtenuante);
            builder.Property(x => x.SintomasAlem).IsRequired();
            builder.Property(x => x.NauseaVomito);
            builder.Property(x => x.SensiLuzSom);
            builder.Property(x => x.PontBriManchEsc);
        }
    }
}
