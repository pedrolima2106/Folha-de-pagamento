using System.ComponentModel.DataAnnotations;

namespace Folha01.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string senha { get; set; }

    }
}
