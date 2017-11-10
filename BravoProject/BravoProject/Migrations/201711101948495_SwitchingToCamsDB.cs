namespace BravoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SwitchingToCamsDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        RequestDate = c.DateTime(nullable: false),
                        CurrentStage = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.RequestID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID);
            
            AddColumn("dbo.AspNetUsers", "Request_RequestID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Request_RequestID");
            AddForeignKey("dbo.AspNetUsers", "Request_RequestID", "dbo.Requests", "RequestID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Request_RequestID", "dbo.Requests");
            DropIndex("dbo.AspNetUsers", new[] { "Request_RequestID" });
            DropIndex("dbo.Requests", new[] { "UserID" });
            DropColumn("dbo.AspNetUsers", "Request_RequestID");
            DropTable("dbo.Requests");
        }
    }
}
