namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Manufacturer
    {
        [Key]
        [MaxLength(10)]
        public string ManuId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
