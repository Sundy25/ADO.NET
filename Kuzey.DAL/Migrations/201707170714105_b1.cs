namespace Kuzey.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiparisDetaylari",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        UrunFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adet = c.Short(nullable: false),
                        Indirim = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.SiparisId, t.UrunId })
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(nullable: false),
                        IstenenTarih = c.DateTime(),
                        Navlun = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adres = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylari", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylari", "SiparisId", "dbo.Siparisler");
            DropIndex("dbo.SiparisDetaylari", new[] { "UrunId" });
            DropIndex("dbo.SiparisDetaylari", new[] { "SiparisId" });
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylari");
        }
    }
}
