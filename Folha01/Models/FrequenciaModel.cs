using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{

    [Table("Frequencia")]
    public class FrequenciaModel
    {
        [Column("IdFrequencia")]
        [Display(Name = "IdFrequencia")]
        [Key]
        public int IdFrequencia { get; set; }

        [Column("Data")]
        [Display(Name = "Data")]
        public double Data { get; set; }

        [Column("Faltas")]
        [Display(Name = "Faltas")]
        public int Faltas { get; set; }

        [Column("IdFuncionario")]
        [Display(Name = "IdFuncionario")]
        public int IdFuncionario { get; set; }


    }
}


/*create table [Frequencia](
[id Frequencia] int not null primary key,
[Data] date not null,
[Faltas] int,
[ID Funcionario] int not null,
foreign key ([ID Funcionario]) references [Funcionario] ([id Funcionario])
);*/