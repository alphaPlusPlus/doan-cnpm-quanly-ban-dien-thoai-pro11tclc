namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class OperatingSystem
    {
        [Key]
        [MaxLength(10)]
        public string OsId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
