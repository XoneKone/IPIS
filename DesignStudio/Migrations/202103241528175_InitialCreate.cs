namespace DesignStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        MiddleName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        MobilePhone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Description = c.String(),
                        ReadyStatus = c.Int(nullable: false),
                        ClientId = c.Int(),
                        DesignerId = c.Int(),
                        PaymentStatus = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        DeadlineWork = c.Int(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Designers", t => t.DesignerId)
                .Index(t => t.ClientId)
                .Index(t => t.DesignerId);
            
            CreateTable(
                "dbo.Designers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        MiddleName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        MobilePhone = c.String(),
                        Address = c.String(),
                        Salary = c.Double(nullable: false),
                        Post = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DesignerId", "dbo.Designers");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "DesignerId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropTable("dbo.Designers");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
        }
    }
}
