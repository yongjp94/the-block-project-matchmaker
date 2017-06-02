namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
                
            Sql(@"INSERT INTO QuestionTypes(Id, Name)
                  VALUES(1, 'Multiple')");
            Sql(@"INSERT INTO QuestionTypes(Id, Name)
                  VALUES(2, 'Binary')");
            Sql(@"INSERT INTO QuestionTypes(Id, Name)
                  VALUES(3, 'Free')");

        }
        
        public override void Down()
        {
            DropTable("dbo.QuestionTypes");
        }
    }
}
