using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("ASSURANCE")]
    public partial class Assurance
    {
        public Assurance()
        {
            Licences = new HashSet<Licence>();
        }

        [Key]
        [Column("ASSU_ID", TypeName = "int(2)")]
        public int AssuId { get; set; }
        [Column("ASSU_NOM")]
        [StringLength(32)]
        public string? AssuNom { get; set; }

        [InverseProperty("Assu")]
        public virtual ICollection<Licence> Licences { get; set; }
    }
}
