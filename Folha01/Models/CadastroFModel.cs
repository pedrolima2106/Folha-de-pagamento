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
        public string NomeFuncionario { get; set; }
        public double Cpf { get; set; }
        public double Cep { get; set; }
        public string DatadeNascimento { get; set; }
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