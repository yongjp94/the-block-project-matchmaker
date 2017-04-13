namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntegrateRelativityInProfileTablesWithUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "GenderId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "NeighborhoodId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "RaceId", c => c.Byte(nullable: false));
            CreateIndex("dbo.AspNetUsers", "GenderId");
            CreateIndex("dbo.AspNetUsers", "NeighborhoodId");
            CreateIndex("dbo.AspNetUsers", "RaceId");
            AddForeignKey("dbo.AspNetUsers", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUsers", "NeighborhoodId", "dbo.Neighborhoods", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUsers", "RaceId", "dbo.Races", "Id", cascadeDelete: true);
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Neighborhood");
            DropColumn("dbo.AspNetUsers", "Race");
            DropTable("dbo.Languages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Race", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Neighborhood", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String(nullable: false));
            DropForeignKey("dbo.AspNetUsers", "RaceId", "dbo.Races");
            DropForeignKey("dbo.AspNetUsers", "NeighborhoodId", "dbo.Neighborhoods");
            DropForeignKey("dbo.AspNetUsers", "GenderId", "dbo.Genders");
            DropIndex("dbo.AspNetUsers", new[] { "RaceId" });
            DropIndex("dbo.AspNetUsers", new[] { "NeighborhoodId" });
            DropIndex("dbo.AspNetUsers", new[] { "GenderId" });
            DropColumn("dbo.AspNetUsers", "RaceId");
            DropColumn("dbo.AspNetUsers", "NeighborhoodId");
            DropColumn("dbo.AspNetUsers", "GenderId");
        }
    }
}
