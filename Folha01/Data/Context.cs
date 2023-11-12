using Folha01.Models;
using Microsoft.EntityFrameworkCore;

namespace Folha01.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // Define as tabelas do banco de dados como DbSet
        public DbSet<CadastroFModel> Lista { get; set; } // Tabela para funcionários
        public DbSet<BeneficiosModel> Beneficios { get; set; } // Tabela para benefícios
        public DbSet<CargoModel> Cargo { get; set; } // Tabela para cargos
        public DbSet<ContratoModel> Contrato { get; set; } // Tabela para contratos
        public DbSet<FrequenciaModel> Frequencias { get; set; } // Tabela para frequências
        public DbSet<HoleriteModel> Holerite { get; set; } // Tabela para holerites
        public DbSet<LoginModel> LoginF { get; set; } // Tabela para logins de funcionários

        public DbSet<FolhaPagamentoModel> folhaPagamentos { get; set; }
    }
}
