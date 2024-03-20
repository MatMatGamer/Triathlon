using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("CATEGORIE")]
    public partial class Categorie
    {
        public Categorie()
        {
            Licences = new HashSet<Licence>();
        }

        [Key]
        [Column("CAT_ID", TypeName = "int(4)")]
        public int CatId { get; set; }
        [Column("CAT_LIBELLE")]
        [StringLength(128)]
        public string? CatLibelle { get; set; }
        [Column("CAT_AGE_DEBUT", TypeName = "int(2)")]
        public int? CatAgeDebut { get; set; }
        [Column("CAT_AGE_FIN", TypeName = "int(2)")]
        public int? CatAgeFin { get; set; }

        [InverseProperty("Cat")]
        public virtual ICollection<Licence> Licences { get; set; }
    }
}
