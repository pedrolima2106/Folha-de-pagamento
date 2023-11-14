using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{

    [Table("FREQUENCIA")]
    public class FrequenciaModel
    {
        [Column("ID")]
        [Display(Name = "IdFrequencia")]
        [Key]
        public int IdFrequencia { get; set; }

        [Column("DATA")]
        [Display(Name = "Data")]
        public double Data { get; set; }

        [Column("FALTAS")]
        [Display(Name = "Faltas")]
        public int Faltas { get; set; }

        [Column("FUNCIONARIO")]
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