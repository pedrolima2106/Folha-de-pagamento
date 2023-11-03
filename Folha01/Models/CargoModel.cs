using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Folha01.Models
{

    [Table("Funcionario Cargo")]
    public class CargoModel
    {

        [Column("IdCadastro")]
        [Display(Name = "IdCadastro")]
        [Key]
        public int IdCargo { get; set; }

        [Column("Função")]
        [Display(Name = "Função")]
        public string Funcao { get; set; }

    }
}


/*[id Cargo] int not null primary key,
 * [Funcao] char(3) not null
*/