using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Folha01.Models
{
    [Table("Holerite")]
    public class HoleriteModel
    {
        [Column("ID")]
        [Display(Name = "IDHolerite")]
        [Key]
        public int IDHolerite { get; set; }

        [Column("FUNCIONARIO")]
        [Display(Name = "IdFuncionario")]
        public int IdFuncionario { get; set; }

        [Column("CONTRATO")]
        [Display(Name = "Codigo Contrato")]
        public int Contrato { get; set; }

        [Column("BENEFICIO")]
        [Display(Name = "IdBeneficios")]
        public int IdBeneficios { get; set; }

        [Column("FREQUENCIA")]
        [Display(Name = "IdFrequencia")]
        public int IdFrequencia { get; set; }

        [Column("DT_ATUAL")]
        [Display(Name = "Data Atual")]
        public DateTime DataAtual { get; set; }

        [Column("DT_ADMISSAO")]
        [Display(Name = "Data de Admissao")]
        public DateTime DataAdmissao { get; set; }

        [Column("SALARIO_BASE")]
        [Display(Name = "Salario Base")]
        public double SalarioBase { get; set; }

        [Column("SALARIO_LIQUIDO")]
        [Display(Name = "Salario Liquido")]
        public double SalarioLiquido { get; set; }
    }
}

/*Create table [Holerites](
[IDHolerite] int not null primary key,
[ID_Funcionario] int not null,
[Codigo_Contrato] int not null,
[ID_Beneficios] int not null,
[ID_Frequencia] int not null,
[Data_Admissao] date,
[Data_Atual] date,
[salario_base] decimal (10, 2),
[salario_liquido] decimal (10, 2),
foreign key ([Codigo_Contrato]) references [Contrato] ([ID Cargo]),
foreign key ([ID_Funcionario]) references [Funcionario] ([id Funcionario]),
foreign key ([ID_Beneficios]) references [Beneficios] ([ID Beneficios]),
foreign key ([ID_Frequencia]) references [Frequencia] ([id Frequencia])
);*/