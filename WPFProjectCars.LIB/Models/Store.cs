namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            CafeOrder = new HashSet<CafeOrder>();
            StoreStock = new HashSet<StoreStock>();
        }

        public int StoreID { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreName { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string StorePhone { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CafeOrder> CafeOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreStock> StoreStock { get; set; }
    }
}
