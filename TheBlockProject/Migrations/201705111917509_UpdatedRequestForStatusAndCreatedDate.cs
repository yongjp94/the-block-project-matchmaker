namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRequestForStatusAndCreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "Status", c => c.String(nullable: false));
            AddColumn("dbo.Requests", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Requests", "SenderId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Requests", "ReceiverId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Requests", "SenderId");
            CreateIndex("dbo.Requests", "ReceiverId");
            AddForeignKey("dbo.Requests", "ReceiverId", "dbo.AspNetUsers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Requests", "SenderId", "dbo.AspNetUsers", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "SenderId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "ReceiverId", "dbo.AspNetUsers");
            DropIndex("dbo.Requests", new[] { "ReceiverId" });
            DropIndex("dbo.Requests", new[] { "SenderId" });
            AlterColumn("dbo.Requests", "ReceiverId", c => c.String(nullable: false));
            AlterColumn("dbo.Requests", "SenderId", c => c.String(nullable: false));
            DropColumn("dbo.Requests", "CreatedDate");
            DropColumn("dbo.Requests", "Status");
        }
    }
}
