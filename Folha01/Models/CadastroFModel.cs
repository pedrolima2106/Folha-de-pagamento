using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{
    [Table("Funcionario cadastro")]
    public class CadastroFModel
    {
        [Column("IdFuncionario")]
        [Display(Name = "IdFuncionario")]
        [Key]
        public int IdFuncionario  { get; set; }

        [Column("NomeFuncionario")]
        [Display(Name = "Nome do Funcionario")]
        public string NomeFuncionario { get; set; }

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public double Cpf { get; set; }

        [Column("Cep")]
        [Display(Name = "Cep")]
        public double Cep { get; set; }

        [Column("DatadeNascimento")]
        [Display(Name = "Data de Nascimento")]
        public string DatadeNascimento { get; set; }

        [Column("Gmail")]
        [Display(Name = "Gmail")]
        public string Gmail { get; set; }
    }
}


/*create table [Funcionario](
[id Funcionario] int not null primary key, 
[Nome do Funcionario] varchar(200) not null,
[CPF] char(11) not null,
[CEP] char(8) not null,
[Data de Nascimento] date,
[Gmail] varchar(200),
[id Login] int not null
foreign key ([id login]) references [Login] ([ID Login])
);*/