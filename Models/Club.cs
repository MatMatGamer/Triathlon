using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("CLUB")]
    public partial class Club
    {
        public Club()
        {
            Licences = new HashSet<Licence>();
        }

        [Key]
        [Column("CLUB_ID", TypeName = "int(2)")]
        public int ClubId { get; set; }
        [Column("CLUB_NOM")]
        [StringLength(128)]
        public string? ClubNom { get; set; }
        [Column("CLUB_RUE")]
        [StringLength(128)]
        public string? ClubRue { get; set; }
        [Column("CLUB_TEL")]
        [StringLength(32)]
        public string? ClubTel { get; set; }
        [Column("CLUB_VILLE")]
        [StringLength(128)]
        public string? ClubVille { get; set; }
        [Column("CLUB_CP")]
        [StringLength(5)]
        public string? ClubCp { get; set; }
        [Column("NB_LICENCIES", TypeName = "int(11)")]
        public int? NbLicencies { get; set; }

        [InverseProperty("Club")]
        public virtual ICollection<Licence> Licences { get; set; }
    }
}
