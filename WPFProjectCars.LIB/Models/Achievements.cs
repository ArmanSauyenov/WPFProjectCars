namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Achievements
    {
        [Key]
        public int Achievements_id { get; set; }

        public int? Players_id { get; set; }

        public int? Countries_id { get; set; }

        public int? Tournaments_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Place { get; set; }

        public virtual Countries Countries { get; set; }

        public virtual Players Players { get; set; }

        public virtual Tournaments Tournaments { get; set; }
    }
}
