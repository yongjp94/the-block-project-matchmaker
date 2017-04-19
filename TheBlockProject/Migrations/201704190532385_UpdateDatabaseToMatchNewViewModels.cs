namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseToMatchNewViewModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Biography", c => c.String());
            CreateIndex("dbo.Answers", "QuestionId");
            CreateIndex("dbo.UserAnswers", "AnswerId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserAnswers", "AnswerId", "dbo.Answers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAnswers", "AnswerId", "dbo.Answers");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.UserAnswers", new[] { "AnswerId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropColumn("dbo.AspNetUsers", "Biography");
        }
    }
}
