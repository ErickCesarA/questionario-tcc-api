using questionario_tcc_api.Models;

namespace questionario_tcc_api.Repositorios.Interfaces
{
    public interface IPacienteRepos
    {
        Task<List<PacienteModel>> BuscarTodosPacientes();
        Task<PacienteModel?> BuscarPacientePorId(int id);
        Task<PacienteModel> AdicionarPaciente(PacienteModel paciente);
        Task<PacienteModel> AtualizarPaciente(PacienteModel paciente, int id);
        Task<bool> ApagarPaciente(int id);
       
    }
}
