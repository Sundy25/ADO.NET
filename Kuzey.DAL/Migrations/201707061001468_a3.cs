namespace Kuzey.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 50),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriId = c.Int(nullable: false),
                        SatistaMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropTable("dbo.Urunler");
        }
    }
}
