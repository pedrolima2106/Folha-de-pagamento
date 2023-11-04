using System.ComponentModel.DataAnnotations;

namespace Folha01.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string senha { get; set; }

    }
}
