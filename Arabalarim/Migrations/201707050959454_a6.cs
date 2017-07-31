namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModelRenks",
                c => new
                    {
                        ModelID = c.Int(nullable: false),
                        RenkID = c.Int(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Model_ModelID = c.Int(),
                    })
                .PrimaryKey(t => new { t.ModelID, t.RenkID })
                .ForeignKey("dbo.Modeller", t => t.ModelID, cascadeDelete: true)
                .ForeignKey("dbo.Modeller", t => t.Model_ModelID)
                .Index(t => t.ModelID)
                .Index(t => t.Model_ModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModelRenks", "Model_ModelID", "dbo.Modeller");
            DropForeignKey("dbo.ModelRenks", "ModelID", "dbo.Modeller");
            DropIndex("dbo.ModelRenks", new[] { "Model_ModelID" });
            DropIndex("dbo.ModelRenks", new[] { "ModelID" });
            DropTable("dbo.ModelRenks");
        }
    }
}
