using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Triathlon.Models
{
    [Table("TYPE_TRIATHLON")]
    public partial class TypeTriathlon
    {
        public TypeTriathlon()
        {
            Triathlons = new HashSet<Triathlon>();
        }

        [Key]
        [Column("TYPE_ID", TypeName = "int(5)")]
        public int TypeId { get; set; }
        [Column("TYPE_LIBELLE")]
        [StringLength(128)]
        public string? TypeLibelle { get; set; }
        [Column("TYPE_DISTANCE_VELO")]
        [Precision(10, 2)]
        public decimal? TypeDistanceVelo { get; set; }
        [Column("TYPE_DISTANCE_COURSE")]
        [Precision(10, 2)]
        public decimal? TypeDistanceCourse { get; set; }
        [Column("TYPE_DISTANCE_NATATION")]
        [Precision(10, 2)]
        public decimal? TypeDistanceNatation { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Triathlon> Triathlons { get; set; }
    }
}
