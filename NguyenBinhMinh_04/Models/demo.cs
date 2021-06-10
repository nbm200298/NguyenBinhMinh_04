using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenBinhMinh_04.Models
{
    public class demo
    {
        [Key]
        public int IDDemo { get; set; }
        public string TenDemo { get; set; }
    }
}