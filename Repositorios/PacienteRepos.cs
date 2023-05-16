using Microsoft.EntityFrameworkCore;
using questionario_tcc_api.Data;
using questionario_tcc_api.Models;
using questionario_tcc_api.Repositorios.Interfaces;

namespace questionario_tcc_api.Repositorios
{
    public class PacienteRepos : IPacienteRepos
    {
        private readonly RegistroDePacientesDbContext _dbcontext;
        public PacienteRepos(RegistroDePacientesDbContext registroDePacientesDbContext)
        {
            _dbcontext = registroDePacientesDbContext;
        }
        public async Task<List<PacienteModel>> BuscarTodosPacientes()
        {
            return await _dbcontext.Paciente.ToListAsync();
        }
        public async Task<PacienteModel> AdicionarPaciente(PacienteModel paciente)
        {
            await _dbcontext.Paciente.AddAsync(paciente);
            await _dbcontext.SaveChangesAsync();

            return paciente;

        }
        public async Task<PacienteModel?> BuscarPacientePorId(int id)
        {
            return await _dbcontext.Paciente.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<PacienteModel> AtualizarPaciente(PacienteModel paciente, int id)
        {
            PacienteModel? pacientePorId = await BuscarPacientePorId(id);
            if(pacientePorId == null) 
            {
                throw new Exception("Paciente não encontrado");
            }
            pacientePorId.Idade = paciente.Idade;
            pacientePorId.Nome = paciente.Nome;
            pacientePorId.Telefone = paciente.Telefone;
            pacientePorId.StatusCivil = paciente.StatusCivil;
            pacientePorId.Etnia = paciente.Etnia;
            pacientePorId.DoencaCronica = paciente.DoencaCronica;
            pacientePorId.QualDoenca = paciente.QualDoenca;
            pacientePorId.HoraExercicio = paciente.HoraExercicio;
            pacientePorId.MedicamentoContinuo = paciente.MedicamentoContinuo;
            pacientePorId.QualMedicamento = paciente.QualMedicamento;
            pacientePorId.MlCafeSemana = paciente.MlCafeSemana;
            pacientePorId.Fuma = paciente.Fuma;
            pacientePorId.QtdMacosSemana = paciente.QtdMacosSemana;
            pacientePorId.Bebida = paciente.Bebida;
            pacientePorId.BedidasSemana = paciente.BedidasSemana;
            pacientePorId.AnosCafeleia = paciente.AnosCafeleia;
            pacientePorId.EpisodiosMes = paciente.EpisodiosMes;
            pacientePorId.BuscaProficional  = paciente.BuscaProficional;
            pacientePorId.Melhora = paciente.Melhora;
            pacientePorId.LocalDorX = paciente.LocalDorX;
            pacientePorId.LocalDorY = paciente.LocalDorY;
            pacientePorId.LocalMaiorDorX = paciente.LocalMaiorDorX;
            pacientePorId.LocalMaiorDorY = paciente.LocalMaiorDorY;
            pacientePorId.MaiorDor24h = paciente.MaiorDor24h;
            pacientePorId.MenorDor24h = paciente.MenorDor24h;
            pacientePorId.GeralDor24h = paciente.GeralDor24h;
            pacientePorId.DorMomento = paciente.DorMomento;
            pacientePorId.TratamentoDor = paciente.TratamentoDor;
            pacientePorId.DorAtividadeGeral = paciente.DorAtividadeGeral;
            pacientePorId.DorHumor = paciente.DorHumor;
            pacientePorId.DorLocomocao = paciente.DorLocomocao;
            pacientePorId.DorTrabalho = paciente.DorTrabalho;
            pacientePorId.DorRelacionamento = paciente.DorRelacionamento;
            pacientePorId.DorSono = paciente.DorSono;
            pacientePorId.DorVida = paciente.DorVida;
            pacientePorId.LocalExataDor = paciente.LocalExataDor;
            pacientePorId.DorIrradia = paciente.DorIrradia;
            pacientePorId.LocalIrradiaDorX = paciente.LocalIrradiaDorX;
            pacientePorId.LocalIrradiaDorY = paciente.LocalIrradiaDorY;
            pacientePorId.DiscriçãoDor = paciente.DiscriçãoDor;
            pacientePorId.ItensidadeDor = paciente.ItensidadeDor;
            pacientePorId.TempoPicoDor = paciente.TempoPicoDor;
            pacientePorId.TempoCrise = paciente.TempoCrise;
            pacientePorId.FatorAgravante = paciente.FatorAgravante;
            pacientePorId.QualFatorAgravante = paciente.QualFatorAgravante;
            pacientePorId.FatorAtenuante = paciente.FatorAtenuante;
            pacientePorId.QualFatorAtenuante = paciente.QualFatorAtenuante;
            pacientePorId.SintomasAlem = paciente.SintomasAlem;
            pacientePorId.NauseaVomito = paciente.NauseaVomito;
            pacientePorId.SensiLuzSom = paciente.SensiLuzSom;
            pacientePorId.PontBriManchEsc = paciente.PontBriManchEsc;

            _dbcontext.Paciente.Update(pacientePorId);
            await _dbcontext.SaveChangesAsync();
            return pacientePorId;
        }
        public async Task<bool> ApagarPaciente(int id)
        {
            PacienteModel? pacientePorId = await BuscarPacientePorId(id);
            if (pacientePorId == null)
            {
                throw new Exception("Paciente não encontrado");
            }

            _dbcontext.Paciente.Remove(pacientePorId);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
