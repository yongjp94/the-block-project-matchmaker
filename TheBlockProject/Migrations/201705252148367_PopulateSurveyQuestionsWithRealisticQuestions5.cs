namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyQuestionsWithRealisticQuestions5 : DbMigration
    {
        public override void Up()
        {
            //Resident-related Questions
            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have a history of mental illness?', 1, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have a history of addiction to illicit substances?', 1, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What is your occupation?', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('I prefer to go to bed between the hours of: ', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('I prefer to wake up between the hours of: ', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What is your daily schedule?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you usually socialize inside or outside your home?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What do you do when you have a conflict with someone?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('List 5-7 characteristics in a person that you get along with well:', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('In 3-5 sentences, please explain why you want to be a part of the Block Project?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('In your new home, where do you plan to socialize?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What are your top concerns as a prospective Block Project participant?', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, Comment, SurveyId, QuestionTypeId) 
                VALUES ('What skills do you have that you like to do in your free time?',
                        '(e.g. carpentry, mechanic, music, cooking, translation, etc.)', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What are your hobbies?', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Will any other adults be included on the lease?', 1, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Will any children reside in the Block home with you at any time?', 1, 2)");
            
            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What pets do you have?', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('My pet(s) get along well with: ', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('My pet(s) do NOT get along well with: ', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Generally, how loud are you?', 1, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Caseworker agency:', 1, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Caseworker''s name:', 1, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
