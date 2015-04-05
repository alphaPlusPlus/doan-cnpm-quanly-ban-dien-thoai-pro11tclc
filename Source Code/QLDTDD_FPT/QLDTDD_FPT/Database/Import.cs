namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Import
    {
        [Key]
        [MaxLength(10)]
        public string ImportId { get; set; }
        [Column(TypeName = "DateTime2")]
        [Required]
        public System.DateTime ImportDate { get; set; }
        [Required]
        [MaxLength(10)]
        public string StaffId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [MaxLength(10)]
        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
