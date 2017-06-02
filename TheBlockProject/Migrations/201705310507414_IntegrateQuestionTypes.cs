namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntegrateQuestionTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Questions", "QuestionTypeId");
            AddForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes");
            DropIndex("dbo.Questions", new[] { "QuestionTypeId" });
            DropColumn("dbo.Questions", "QuestionTypeId");
        }
    }
}
