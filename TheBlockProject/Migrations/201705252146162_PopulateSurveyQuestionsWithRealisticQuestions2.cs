namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyQuestionsWithRealisticQuestions2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questions", "IsMandatory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "IsMandatory", c => c.Boolean(nullable: false));
        }
    }
}
