using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("Classe")]
    public partial class Classe
    {
        public Classe()
        {
            Substances = new HashSet<Substance>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("libelle")]
        [StringLength(75)]
        public string Libelle { get; set; } = null!;

        [InverseProperty("IdClasseNavigation")]
        public virtual ICollection<Substance> Substances { get; set; }
    }
}
