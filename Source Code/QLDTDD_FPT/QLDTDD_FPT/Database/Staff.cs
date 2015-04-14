namespace QLDTDD_FPT.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Staff
    {
        [Key]
        [MaxLength(10)] 
        public string StaffId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(15)]
        [Required]
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        [MaxLength(10)]
        [Required]
        public string UserRole { get; set; }
        [MaxLength(50)]
        public string UserId { get; set; }
        [MaxLength(50)]
        public string Pass { get; set; }
        [Column(TypeName = "DateTime2")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public int MonthlySalary { get; set; }
    
        public virtual ICollection<Export> Exports { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<TimeBook> TimeBooks { get; set; }
    }
}
