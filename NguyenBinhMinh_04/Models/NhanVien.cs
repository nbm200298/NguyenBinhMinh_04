using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenBinhMinh_04.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int  MaTinhThanh { get; set; }
        //public ICollection<TinhThanh> TinhThanhs { get; set; }
    }
}