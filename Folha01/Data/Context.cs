using Folha01.Models;
using Microsoft.EntityFrameworkCore;

namespace Folha01.Data
{
    public class Context : DbContext 
    {

        public Context(DbContextOptions<Context> options) : base(options) 
        {
        
        }

        public DbSet<CadastroFModel> Lista { get; set; }
        public DbSet<BeneficiosModel> beneficios { get; set; }
        public DbSet<CargoModel> cargo { get; set; }
        public DbSet<ContratoModel> contrato { get; set; }
        public DbSet<FrequenciaModel> frequencias { get; set; }
        public DbSet<HoleriteModel> holerite { get; set; }
        public DbSet<LoginModel> LoginF { get; set; }
    }
}
