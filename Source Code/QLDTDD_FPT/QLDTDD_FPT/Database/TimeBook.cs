namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class TimeBook
    {
        [Key]
        [MaxLength(10)]
        public string TimeBookId { get; set; }
        [Required]
        [MaxLength(10)]
        public string StaffId { get; set; }
        [Column(TypeName = "DateTime2")]
        [Required]
        public System.DateTime WorkDay { get; set; }
        [Column(TypeName = "DateTime2")]
        [Required]
        public System.DateTime OffDay { get; set; }
        [Required]
        public int NumberOfSoldProduct { get; set; }
        public int? Revenue { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}
