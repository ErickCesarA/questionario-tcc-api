﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using questionario_tcc_api.Data;

#nullable disable

namespace questionario_tcc_api.Migrations
{
    [DbContext(typeof(RegistroDePacientesDbContext))]
    partial class RegistroDePacientesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("questionario_tcc_api.Models.PacienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnosCafeleia")
                        .HasColumnType("int");

                    b.Property<bool>("Bebida")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("BedidasSemana")
                        .HasColumnType("int");

                    b.Property<bool>("BuscaProficional")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DiscriçãoDor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("DoencaCronica")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("DorAtividadeGeral")
                        .HasColumnType("int");

                    b.Property<int>("DorHumor")
                        .HasColumnType("int");

                    b.Property<bool>("DorIrradia")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("DorLocomocao")
                        .HasColumnType("int");

                    b.Property<int>("DorMomento")
                        .HasColumnType("int");

                    b.Property<int>("DorRelacionamento")
                        .HasColumnType("int");

                    b.Property<int>("DorSono")
                        .HasColumnType("int");

                    b.Property<int>("DorTrabalho")
                        .HasColumnType("int");

                    b.Property<int>("DorVida")
                        .HasColumnType("int");

                    b.Property<int>("EpisodiosMes")
                        .HasColumnType("int");

                    b.Property<int>("Etnia")
                        .HasColumnType("int");

                    b.Property<bool>("FatorAgravante")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FatorAtenuante")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Fuma")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("GeralDor24h")
                        .HasColumnType("int");

                    b.Property<int>("HoraExercicio")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<int>("ItensidadeDor")
                        .HasColumnType("int");

                    b.Property<double>("LocalDorX")
                        .HasColumnType("double");

                    b.Property<double>("LocalDorY")
                        .HasColumnType("double");

                    b.Property<int>("LocalExataDor")
                        .HasColumnType("int");

                    b.Property<double>("LocalIrradiaDorX")
                        .HasColumnType("double");

                    b.Property<double>("LocalIrradiaDorY")
                        .HasColumnType("double");

                    b.Property<double>("LocalMaiorDorX")
                        .HasColumnType("double");

                    b.Property<double>("LocalMaiorDorY")
                        .HasColumnType("double");

                    b.Property<int>("MaiorDor24h")
                        .HasColumnType("int");

                    b.Property<bool>("MedicamentoContinuo")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Melhora")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MenorDor24h")
                        .HasColumnType("int");

                    b.Property<int>("MlCafeSemana")
                        .HasColumnType("int");

                    b.Property<bool>("NauseaVomito")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PontBriManchEsc")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QtdMacosSemana")
                        .HasColumnType("int");

                    b.Property<string>("QualDoenca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QualFatorAgravante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QualFatorAtenuante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QualMedicamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("SensiLuzSom")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SintomasAlem")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("StatusCivil")
                        .HasColumnType("int");

                    b.Property<string>("TempoCrise")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TempoPicoDor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TratamentoDor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
