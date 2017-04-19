namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateQuestionTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Both Question 1', 3, 1)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Both Question 2', 3, 1)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Both Question 3', 3, 1)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Both Question 4', 3, 1)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Resident Only Question 1', 1, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Resident Only Question 2', 1, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Resident Only Question 3', 1, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 1', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 2', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 3', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 4', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 5', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 6', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 7', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 8', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 9', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 10', 2, 0)");
            Sql("INSERT INTO Questions(Text, SurveyId, IsMandatory) VALUES ('Dummy Host Only Question 11', 2, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
