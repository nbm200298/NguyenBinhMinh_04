namespace NguyenBinhMinh_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableDemo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.demoes",
                c => new
                    {
                        IDDemo = c.Int(nullable: false, identity: true),
                        TenDemo = c.String(),
                    })
                .PrimaryKey(t => t.IDDemo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.demoes");
        }
    }
}
