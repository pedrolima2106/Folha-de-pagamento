﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Folha01.Models
{

    [Table("Contratos")]
    public class ContratoModel
    {
        [Column("IdContrato")]
        [Display(Name = "Codigo do Contrto")]
        [Key]
        public int IdContrato { get; set; }

    }
}

