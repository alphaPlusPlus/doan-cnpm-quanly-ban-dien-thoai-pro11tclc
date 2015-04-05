namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Product
    {
        [Key]
        [MaxLength(10)] 
        public string ProductId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [MaxLength(10)] 
        [Required]
        public string ManuId { get; set; }
        [MaxLength(10)]
        [Required]
        public string ColorId { get; set; }
        [MaxLength(50)]
        public string Source { get; set; }
        [Required]
        public int Price { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual ICollection<Export> Exports { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
