namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modeller", "MotorHacmi", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modeller", "MotorHacmi");
        }
    }
}
