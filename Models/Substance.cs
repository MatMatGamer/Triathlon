using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("substance")]
    [Index("IdClasse", Name = "fk_Substance_idClasse")]
    public partial class Substance
    {
        public Substance()
        {
            ControleSubstances = new HashSet<ControleSubstance>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(75)]
        public string Nom { get; set; } = null!;
        [Column("idClasse", TypeName = "int(11)")]
        public int IdClasse { get; set; }
        [Column("seuil")]
        [Precision(5, 3)]
        public decimal Seuil { get; set; }

        [ForeignKey("IdClasse")]
        [InverseProperty("Substances")]
        public virtual Classe IdClasseNavigation { get; set; } = null!;
        [InverseProperty("IdSubstanceNavigation")]
        public virtual ICollection<ControleSubstance> ControleSubstances { get; set; }
    }
}
