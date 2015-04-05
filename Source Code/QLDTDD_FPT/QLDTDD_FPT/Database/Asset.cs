using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTDD_FPT.Database
{
    public class Asset : Product
    {
        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
