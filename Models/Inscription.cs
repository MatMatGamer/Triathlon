using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("INSCRIPTION")]
    [Index("LicId", Name = "I_FK_INSCRIPTION_LICENCE")]
    [Index("TriId", Name = "I_FK_INSCRIPTION_TRIATHLON")]
    public partial class Inscription
    {
        [Key]
        [Column("TRI_ID", TypeName = "int(3)")]
        public int TriId { get; set; }
        [Key]
        [Column("INSC_DOSSARD", TypeName = "int(11)")]
        public int InscDossard { get; set; }
        [Column("LIC_ID", TypeName = "int(5)")]
        public int LicId { get; set; }
        [Column("INSC_CLASSEMENT", TypeName = "int(4)")]
        public int? InscClassement { get; set; }
        [Column("INSC_DATE_INSCRIPTION")]
        public DateOnly? InscDateInscription { get; set; }
        [Column("INSC_TEMPS_NATATION")]
        [Precision(10, 2)]
        public decimal? InscTempsNatation { get; set; }
        [Column("INSC_TEMPS_VELO")]
        [Precision(10, 2)]
        public decimal? InscTempsVelo { get; set; }
        [Column("INSC_TEMPS_COURSE")]
        [Precision(10, 2)]
        public decimal? InscTempsCourse { get; set; }
        [Column("INSC_FORFAIT")]
        public bool? InscForfait { get; set; }

        [ForeignKey("LicId")]
        [InverseProperty("Inscriptions")]
        public virtual Licence Lic { get; set; } = null!;
        [ForeignKey("TriId")]
        [InverseProperty("Inscriptions")]
        public virtual Triathlon Tri { get; set; } = null!;
    }
}
