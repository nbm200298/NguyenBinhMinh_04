using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenBinhMinh_04.Models
{
    public partial class LTQLDb : DbContext
    {
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public LTQLDb()
            : base("name=LTQLDb1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        //public System.Data.Entity.DbSet<NguyenBinhMinh_04.Models.NhanVien> NhanViens { get; set; }
    }
}
