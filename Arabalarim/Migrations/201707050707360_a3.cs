namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modeller",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        AD = c.String(nullable: false, maxLength: 100, unicode: false),
                        Yil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modeller");
        }
    }
}
