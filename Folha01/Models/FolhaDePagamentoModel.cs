using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{
    [Table("FolhaDePagamento")]
    public class FolhaPagamentoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o ID do funcionário")]
        public int IdFuncionario { get; set; }

        [Display(Name = "Salário Bruto")]
        [Required(ErrorMessage = "Informe o salário bruto")]
        public decimal SalarioBruto { get; set; }

        [Display(Name = "Descontos")]
        public decimal Descontos { get; set; }

        [Display(Name = "Salário Líquido")]
        public decimal SalarioLiquido { get; set; }

        [Display(Name = "Data de Pagamento")]
        [DataType(DataType.Date)]
        public DateTime DataPagamento { get; set; } = DateTime.Now;

        [ForeignKey("IdFuncionario")]
        public CadastroFModel Funcionario { get; set; }
    }
}