namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentityModelForPureViewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LanguageId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "LanguageId");
            AddForeignKey("dbo.AspNetUsers", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
            DropColumn("dbo.AspNetUsers", "PrimaryLanguage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PrimaryLanguage", c => c.String(nullable: false));
            DropForeignKey("dbo.AspNetUsers", "LanguageId", "dbo.Languages");
            DropIndex("dbo.AspNetUsers", new[] { "LanguageId" });
            DropColumn("dbo.AspNetUsers", "LanguageId");
        }
    }
}
