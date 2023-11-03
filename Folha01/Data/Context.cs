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
        public DbSet<BeneficiosModel> Beneficios { get; set; }
        public DbSet<CargoModel> CargoModels { get; set; }
        public DbSet<ContratoModel> Cargos { get; set; }
        public DbSet<FrequenciaModel> Frequenci { get;set; }
        public DbSet<HoleriteModel> Holerite { get;set; }
    }
}
