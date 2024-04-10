using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("controle")]
    [Index("IdTriathlon", Name = "idTriathlon")]
    [Index("NumDossard", Name = "numDossard")]
    public partial class Controle
    {
        public Controle()
        {
            ControleSubstances = new HashSet<ControleSubstance>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("idTriathlon", TypeName = "int(11)")]
        public int IdTriathlon { get; set; }
        [Column("numDossard", TypeName = "int(11)")]
        public int? NumDossard { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("controleurPrenom", TypeName = "int(11)")]
        public int ControleurPrenom { get; set; }
        [Column("controleurNom", TypeName = "int(11)")]
        public int ControleurNom { get; set; }

        [InverseProperty("IdControleNavigation")]
        public virtual ICollection<ControleSubstance> ControleSubstances { get; set; }
    }
}
