using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("LICENCE")]
    [Index("AssuId", Name = "I_FK_LICENCE_ASSURANCE")]
    [Index("CatId", Name = "I_FK_LICENCE_CATEGORIE")]
    [Index("ClubId", Name = "I_FK_LICENCE_CLUB")]
    public partial class Licence
    {
        public Licence()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        [Key]
        [Column("LIC_ID", TypeName = "int(5)")]
        public int LicId { get; set; }
        [Column("CAT_ID", TypeName = "int(4)")]
        public int? CatId { get; set; }
        [Column("CLUB_ID", TypeName = "int(2)")]
        public int? ClubId { get; set; }
        [Column("ASSU_ID", TypeName = "int(2)")]
        public int? AssuId { get; set; }
        [Column("LIC_PHOTO")]
        public byte[]? LicPhoto { get; set; }
        [Column("LIC_NOM")]
        [StringLength(128)]
        public string? LicNom { get; set; }
        [Column("LIC_PRENOM")]
        [StringLength(128)]
        public string? LicPrenom { get; set; }
        [Column("LIC_SEXE")]
        [StringLength(128)]
        public string? LicSexe { get; set; }
        [Column("LIC_EMAIL")]
        [StringLength(128)]
        public string? LicEmail { get; set; }
        [Column("LIC_RUE")]
        [StringLength(128)]
        public string? LicRue { get; set; }
        [Column("LIC_CODE_POSTAL")]
        [StringLength(32)]
        public string? LicCodePostal { get; set; }
        [Column("LIC_VILLE")]
        [StringLength(128)]
        public string? LicVille { get; set; }
        [Column("LIC_DATE_NAISSANCE")]
        public DateOnly? LicDateNaissance { get; set; }
        [Column("DISCRIMINATOR")]
        [StringLength(30)]
        public string? Discriminator { get; set; }
        [Column("LIC_DATE_PREMIERE_LICE")]
        public DateOnly? LicDatePremiereLice { get; set; }
        [Column("LIC_EST_ENTRAINEUR")]
        public bool? LicEstEntraineur { get; set; }
        [Column("LIC_NUM_ASSURE")]
        [StringLength(32)]
        public string? LicNumAssure { get; set; }
        [Column("LIC_VALIDITE_ASSU")]
        public DateOnly? LicValiditeAssu { get; set; }

        [ForeignKey("AssuId")]
        [InverseProperty("Licences")]
        public virtual Assurance? Assu { get; set; }
        [ForeignKey("CatId")]
        [InverseProperty("Licences")]
        public virtual Categorie? Cat { get; set; }
        [ForeignKey("ClubId")]
        [InverseProperty("Licences")]
        public virtual Club? Club { get; set; }
        [InverseProperty("Lic")]
        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
