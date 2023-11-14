using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Folha01.Models
{
    [Table("Login")]
    public class LoginModel
    {
        [Key]
        public int Id { get; set; } // Chave primária para identificar o login

        [Required(ErrorMessage = "Digite o Login")] // O campo de login é obrigatório
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a Senha")] // O campo de senha é obrigatório
        public string Senha { get; set; }
    }
}
