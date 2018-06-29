namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreStock")]
    public partial class StoreStock
    {
        public int StoreStockID { get; set; }

        public int StoreID { get; set; }

        public int ProductID { get; set; }

        public int? ProductQuantity { get; set; }

        public virtual Products Products { get; set; }

        public virtual Store Store { get; set; }
    }
}
