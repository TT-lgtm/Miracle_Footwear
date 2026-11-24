namespace Miracle_Footwear.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSize")]
    public partial class ProductSize
    {
        [Key]
        public int IDProductSize { get; set; }

        public int ProductId { get; set; }

        public double Size { get; set; }

        public int Stock { get; set; }

        public int InitialStock { get; set; }

        public virtual Product Product { get; set; }
    }
}
