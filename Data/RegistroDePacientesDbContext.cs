using Microsoft.EntityFrameworkCore;
using questionario_tcc_api.Data.Mapping;
using questionario_tcc_api.Models;

namespace questionario_tcc_api.Data
{
    public class RegistroDePacientesDbContext : DbContext
    {
        public RegistroDePacientesDbContext(DbContextOptions<RegistroDePacientesDbContext> options) : base(options)
        {
        }
        public DbSet<PacienteModel> Paciente { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
