//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
