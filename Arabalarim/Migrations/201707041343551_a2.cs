namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Markalar", "Falani", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Markalar", "Falani");
        }
    }
}
