namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cafe")]
    public partial class Cafe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cafe()
        {
            CafeOrder = new HashSet<CafeOrder>();
            CafeStock = new HashSet<CafeStock>();
            Sales = new HashSet<Sales>();
        }

        public int CafeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CafeName { get; set; }

        [Required]
        [StringLength(50)]
        public string CafeAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CafePhone { get; set; }

        [Required]
        [StringLength(50)]
        public string CafeEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CafeOrder> CafeOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CafeStock> CafeStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
