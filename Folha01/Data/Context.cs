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
    }
}
