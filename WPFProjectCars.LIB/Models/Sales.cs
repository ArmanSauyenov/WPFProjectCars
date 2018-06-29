namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales
    {
        public int SalesID { get; set; }

        public int FoodID { get; set; }

        public int QuantitySold { get; set; }

        public DateTime DateSold { get; set; }

        public int CafeID { get; set; }

        public virtual Cafe Cafe { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
