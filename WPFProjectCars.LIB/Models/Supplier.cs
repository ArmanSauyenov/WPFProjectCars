namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public int SupplierID { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierName { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierEmail { get; set; }
    }
}
