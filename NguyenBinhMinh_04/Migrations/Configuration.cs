namespace NguyenBinhMinh_04.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NguyenBinhMinh_04.Models.LTQLDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NguyenBinhMinh_04.Models.LTQLDb context)
        {
            //context.TinhThanh.AddOrUpdate(T => T.TenTinhThanh
            //new
            //{ 
            //    TenTinhThanh = "HaNoi",

            //}
            //    );
        }
    }
}
