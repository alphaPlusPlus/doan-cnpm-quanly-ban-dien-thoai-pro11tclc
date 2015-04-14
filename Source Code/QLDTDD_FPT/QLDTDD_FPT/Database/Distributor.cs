namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Distributor
    {
        [Key]
        [MaxLength(10)]
        public string DistrId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
