namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genders", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Neighborhoods", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Photos", "UserId", c => c.String(nullable: false));
            AlterColumn("dbo.Photos", "Url", c => c.String(nullable: false));
            AlterColumn("dbo.Races", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Requests", "SenderId", c => c.String(nullable: false));
            AlterColumn("dbo.Requests", "ReceiverId", c => c.String(nullable: false));
            AlterColumn("dbo.Videos", "UserId", c => c.String(nullable: false));
            AlterColumn("dbo.Videos", "Url", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Url", c => c.String());
            AlterColumn("dbo.Videos", "UserId", c => c.String());
            AlterColumn("dbo.Requests", "ReceiverId", c => c.String());
            AlterColumn("dbo.Requests", "SenderId", c => c.String());
            AlterColumn("dbo.Races", "Name", c => c.String());
            AlterColumn("dbo.Photos", "Url", c => c.String());
            AlterColumn("dbo.Photos", "UserId", c => c.String());
            AlterColumn("dbo.Neighborhoods", "Name", c => c.String());
            AlterColumn("dbo.Genders", "Name", c => c.String());
        }
    }
}
