using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("controle_substance")]
    [Index("IdControle", "IdSubstance", Name = "idControle")]
    [Index("IdSubstance", Name = "idSubstance")]
    public partial class ControleSubstance
    {
        [Key]
        [Column("idControle", TypeName = "int(11)")]
        public int IdControle { get; set; }
        [Key]
        [Column("idSubstance", TypeName = "int(11)")]
        public int IdSubstance { get; set; }
        [Column("montant")]
        [Precision(10, 0)]
        public decimal Montant { get; set; }

        [ForeignKey("IdControle")]
        [InverseProperty("ControleSubstances")]
        public virtual Controle IdControleNavigation { get; set; } = null!;
        [ForeignKey("IdSubstance")]
        [InverseProperty("ControleSubstances")]
        public virtual Substance IdSubstanceNavigation { get; set; } = null!;
    }
}
