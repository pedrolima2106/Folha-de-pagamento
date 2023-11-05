using Folha01.Enums;
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

        [Column("LoginFuncionario")]
        [Display(Name = "Login do Funcionario")]
        [Required(ErrorMessage = "Digite o Login")]
        public string LoginFuncionario { get; set; }

        [Column("SenhaFuncionario")]
        [Display(Name = "Senha do Funcionario")]
        [Required(ErrorMessage = "Digite a Senha")]
        public string SenhaFuncionario { get; set; }
        public PerfilEnum Perfil { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public double Cpf { get; set; }

        [Column("Cep")]
        [Display(Name = "Cep")]
        public double Cep { get; set; }

        [Column("DatadeNascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DatadeNascimento { get; set; }

        public bool SenhaValida(string senha)
        {
            return SenhaFuncionario == senha;
        }

     

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