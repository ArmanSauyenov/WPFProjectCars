namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsMinAmount")]
    public partial class ProductsMinAmount
    {
        [Key]
        [Column("ProductsMinAmount")]
        public int ProductsMinAmount1 { get; set; }

        public int ProductID { get; set; }

        public int MinAmount { get; set; }

        public virtual Products Products { get; set; }
    }
}
