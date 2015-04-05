using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTDD_FPT.Database
{
    public class Phone : Product
    {
        [MaxLength(10)]
        [Required]
        public string OsId { get; set; }
    }
}
