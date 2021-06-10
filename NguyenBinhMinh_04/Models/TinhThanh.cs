using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenBinhMinh_04.Models
{
    public class TinhThanh
    {
        [Key]
        public int MaTinhThanh { get; set; }
        //public string TenTinhTHanh { get; set; }
        //[ForeignKey("TenTinhThanh")]
        public string NhanVien { get; set; }
    }
}