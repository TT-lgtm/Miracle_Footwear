namespace Miracle_Footwear.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            ProductSize = new HashSet<ProductSize>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Subcategory { get; set; }

        [Required]
        [StringLength(50)]
        public string Photo { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Сomposition { get; set; }

        public decimal ProductPrice { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSize> ProductSize { get; set; }
    }
}
