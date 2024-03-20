using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("TRIATHLON")]
    [Index("TypeId", Name = "I_FK_TRIATHLON_TYPE_TRIATHLON")]
    public partial class Triathlon
    {
        public Triathlon()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        [Key]
        [Column("TRI_ID", TypeName = "int(3)")]
        public int TriId { get; set; }
        [Column("TYPE_ID", TypeName = "int(5)")]
        public int TypeId { get; set; }
        [Column("TRI_NOM")]
        [StringLength(128)]
        public string? TriNom { get; set; }
        [Column("TRI_DATE")]
        public DateOnly? TriDate { get; set; }
        [Column("TRI_LIEU")]
        [StringLength(128)]
        public string? TriLieu { get; set; }
        [Column("TRI_VILLE")]
        [StringLength(128)]
        public string? TriVille { get; set; }
        [Column("TRI_CP")]
        [StringLength(32)]
        public string? TriCp { get; set; }

        [ForeignKey("TypeId")]
        [InverseProperty("Triathlons")]
        public virtual TypeTriathlon Type { get; set; } = null!;
        [InverseProperty("Tri")]
        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
