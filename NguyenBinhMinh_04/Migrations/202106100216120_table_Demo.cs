namespace NguyenBinhMinh_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_Demo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        TenNhanVien = c.String(),
                        MaTinhThanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            AddColumn("dbo.TinhThanhs", "NhanVien", c => c.String());
            DropColumn("dbo.TinhThanhs", "TenTinhTHanh");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TinhThanhs", "TenTinhTHanh", c => c.String());
            DropColumn("dbo.TinhThanhs", "NhanVien");
            DropTable("dbo.NhanViens");
        }
    }
}
