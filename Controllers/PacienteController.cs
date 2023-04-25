using Microsoft.AspNetCore.Mvc;
using questionario_tcc_api.Models;
using questionario_tcc_api.Repositorios.Interfaces;

namespace questionario_tcc_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : Controller
    {
        private readonly IPacienteRepos _pacienteRepos;
        public PacienteController(IPacienteRepos pacienteRepos)
        {
            _pacienteRepos = pacienteRepos;
        }
        [HttpGet]
        public async Task<ActionResult<List<PacienteModel>>> BuscarTodosPacientes()
        {
            List<PacienteModel> pacientes = await _pacienteRepos.BuscarTodosPacientes();
            return Ok(pacientes);
        }
        [HttpPost]
        public async Task<ActionResult<PacienteModel>> AdicionarPaciente([FromBody] PacienteModel pacienteModel)
        {
            PacienteModel paciente = await _pacienteRepos.AdicionarPaciente(pacienteModel);
            return Ok(paciente);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteModel?>> BuscarPacientePorId(int id)
        {
            PacienteModel? paciente = await _pacienteRepos.BuscarPacientePorId(id);
            return Ok(paciente);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<PacienteModel>> AtualizarPaciente([FromBody]PacienteModel pacienteModel,int id)
        {
            pacienteModel.Id = id;
            PacienteModel paciente = await _pacienteRepos.AtualizarPaciente(pacienteModel, id);
            return Ok(paciente);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<PacienteModel>> ApagarPaciente(int id)
        {
            bool pacienteApagado = await _pacienteRepos.ApagarPaciente(id);
            return Ok(pacienteApagado);
        }

    }
}
