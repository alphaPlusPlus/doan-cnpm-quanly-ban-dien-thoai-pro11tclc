namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Color
    {
        [Key]
        [MaxLength(10)]
        public string ColorId { get; set; }
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
