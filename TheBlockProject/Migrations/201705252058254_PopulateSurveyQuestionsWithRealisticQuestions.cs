namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyQuestionsWithRealisticQuestions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Text2", c => c.String());



        }

        public override void Down()
        {
            DropColumn("dbo.Questions", "Text2");
            DropColumn("dbo.Questions", "IsMandatory");
        }
    }
}
