namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markalar",
                c => new
                    {
                        MarkaID = c.Int(nullable: false, identity: true),
                        MarkaAdi = c.String(nullable: false, maxLength: 50, unicode: false),
                        KurulusYili = c.Int(),
                        Kurucusu = c.String(),
                    })
                .PrimaryKey(t => t.MarkaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Markalar");
        }
    }
}
