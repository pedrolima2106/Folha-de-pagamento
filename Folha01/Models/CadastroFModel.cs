using Folha01.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{
    // Define a classe de modelo para a entidade "FuncionarioCadastro"
    [Table("FuncionarioCadastro")]
    public class CadastroFModel
    {
        // Propriedade que representa o ID do funcionário
        [Key]
        [Display(Name = "IdFuncionario")]
        public int IdFuncionario { get; set; }

        // Propriedade que representa o nome do funcionário
        [Display(Name = "Nome do Funcionario")]
        public string NomeFuncionario { get; set; }

        // Propriedade que representa o login do funcionário com validação de preenchimento obrigatório
        [Display(Name = "Login do Funcionario")]
        [Required(ErrorMessage = "Digite o Login")]
        public string LoginFuncionario { get; set; }

        // Propriedade que representa a senha do funcionário com validação de preenchimento obrigatório
        [Display(Name = "Senha do Funcionario")]
        [Required(ErrorMessage = "Digite a Senha")]
        [DataType(DataType.Password)] // Define o tipo de dado como senha para ocultação na view
        public string SenhaFuncionario { get; set; }

        // Propriedade que representa o perfil do funcionário (presumo que seja um enum)
        public PerfilEnum Perfil { get; set; }

        // Propriedade que representa o email do funcionário
        [Display(Name = "Email")]
        public string Email { get; set; }

        // Propriedade que representa o CPF do funcionário com validação de formato
        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter 11 dígitos.")]
        public string Cpf { get; set; }

        // Propriedade que representa o CEP do funcionário com validação de formato
        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter 8 dígitos.")]
        public string Cep { get; set; }

        // Propriedade que representa a data de nascimento do funcionário
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)] // Define o tipo de dado como data
        public DateTime DatadeNascimento { get; set; }

        // Método para validar a senha do funcionário
        public bool SenhaValida(string senha)
        {
            // Lógica de validação de senha (personalizada)
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