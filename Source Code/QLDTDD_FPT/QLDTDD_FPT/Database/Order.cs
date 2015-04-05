namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Order
    {
        [Key]
        [MaxLength(10)]
        public string OrderId { get; set; }
        [Required]
        [MaxLength(10)]
        public string ProductId { get; set; }
        [Required]
        [MaxLength(10)]
        public string DistrId { get; set; }
        [Column(TypeName = "DateTime2")]
        [Required]
        public System.DateTime OrderTime { get; set; }
        [Column(TypeName = "DateTime2")]
        [Required]
        public System.DateTime ArrivalTime { get; set; }
        [Required]
        [MaxLength(10)]
        public string StaffId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Deposit { get; set; }
    
        public virtual Distributor Distributor { get; set; }
        public virtual Product Product { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
