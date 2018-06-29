namespace WPFProjectCars.LIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        public int RecipeID { get; set; }

        public int FoodID { get; set; }

        public int ProductID { get; set; }

        public int ProductRequired { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual Products Products { get; set; }
    }
}
