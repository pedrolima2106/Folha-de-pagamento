using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{
    [Table("Beneficios")]
    public class Beneficios
    {
        [Column("IdBeneficios ")]
        [Display(Name = "IdBeneficios")]
        [Key]
        public int IdBeneficios { get; set; }

        [Column("Recisaofuncionario")]
        [Display(Name = "Recisão do funcionario")]
        public string Recisaofuncionario { get; set; }

        [Column("HorasExtras")]
        [Display(Name = "Horas Extras")]
        public string HorasExtras { get; set; }

        [Column("VA")]
        [Display(Name = "VA")]
        public double Va { get; set; }

        [Column("VT")]
        [Display(Name = "VT")]
        public double Vt { get; set; }

        [Column("IdFuncionario")]
        [Display(Name = "IdFuncionario")]
        public int IdFuncionario { get; set; }

    }
}


/*Create table [Beneficios](
[ID Beneficios] int not null primary Key,
[RescisãoFuncionario] varchar(100) not null,
[HorasExtras] varchar(100),
[VA] decimal (5, 2) not null,
[VT] decimal (5,2) not null,
[ID Funcionario] int not null,
[Codigo de Contrato] int not null,
foreign key ([ID Funcionario]) references [Funcionario] ([id Funcionario]),
foreign key ([Codigo de Contrato]) references [Contrato] ([ID Cargo])
);*/