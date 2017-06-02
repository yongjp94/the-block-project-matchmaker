namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyQuestionsWithRealisticQuestions3 : DbMigration
    {
        public override void Up()
        {


            // Matching questions
            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('How accessible are you to public transportation?', 
                        'How important is accessibility to public transit?', 3, 1)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId, QuestionTypeId) 
                VALUES ('Do you currently use any illicit substances?', 
                        'Are you comfortable with someone who uses illicit substances?', 3, 2)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('Do you use marijuana?', 
                        'Are you comfortable with someone who uses marijuana?', 3, 2)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('Do you consume alcohol?', 
                        'Are you comfortable with someone who uses alcohol?', 3, 2)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('Do you use tobacco products?', 
                        'Are you comfortable with someone who uses tobacco products?', 3, 2)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('What is your cleanliness level?', 
                        'What is your cleanliness level?', 3, 1)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('How many belongings do you have?', 
                        'How many belongings do you have?', 3, 1)");

            Sql(@"INSERT INTO Questions(Text, Text2, SurveyId, QuestionTypeId) 
                VALUES ('How much interaction do you prefer to have with your neighbors?', 
                        'How much interaction do you prefer to have with your neighbors?', 3, 1)");




        }
        
        public override void Down()
        {
        }
    }
}
