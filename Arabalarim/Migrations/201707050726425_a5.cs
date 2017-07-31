namespace Arabalarim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modeller", "MarkaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Modeller", "MarkaID"); // nunclustered index - kitab�n arkas�ndaki dizin muhabbeti

            // foreignkeyler clusteredindex olarak tan�mlan�r. 
            AddForeignKey("dbo.Modeller", "MarkaID", "dbo.Markalar", "MarkaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modeller", "MarkaID", "dbo.Markalar");
            DropIndex("dbo.Modeller", new[] { "MarkaID" });
            DropColumn("dbo.Modeller", "MarkaID");
        }
    }
}
