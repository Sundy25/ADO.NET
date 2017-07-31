namespace Kuzey.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Siparisler", "IstenenTarih", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Siparisler", "IstenenTarih", c => c.DateTime());
        }
    }
}
