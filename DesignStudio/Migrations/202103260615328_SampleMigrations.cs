namespace DesignStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "DeadlineWork", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "DeadlineWork", c => c.Int(nullable: false));
        }
    }
}
