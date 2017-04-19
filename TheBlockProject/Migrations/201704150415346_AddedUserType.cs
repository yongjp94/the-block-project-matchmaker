namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.AspNetUsers", "UserTypeId");
            AddForeignKey("dbo.AspNetUsers", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.AspNetUsers", new[] { "UserTypeId" });
            DropColumn("dbo.AspNetUsers", "UserTypeId");
            DropTable("dbo.UserTypes");
        }
    }
}
