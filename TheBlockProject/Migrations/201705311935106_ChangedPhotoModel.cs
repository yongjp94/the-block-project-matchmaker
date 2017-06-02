namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPhotoModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Photos", "ImageData", c => c.Binary(nullable: false));
            AddColumn("dbo.Photos", "ImageMimeType", c => c.Int(nullable: false));
            AddColumn("dbo.Photos", "Thumbnail", c => c.Binary());
            DropColumn("dbo.Photos", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photos", "Url", c => c.String(nullable: false));
            DropColumn("dbo.Photos", "Thumbnail");
            DropColumn("dbo.Photos", "ImageMimeType");
            DropColumn("dbo.Photos", "ImageData");
        }
    }
}
