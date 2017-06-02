namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyQuestionsWithRealisticQuestions4 : DbMigration
    {
        public override void Up()
        {
            // Host-related Questions
            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Please list the nearest transit lines.', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have any health conditions that someone sharing space should know about?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have a history of mental health?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Describe any history of your mental health:', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have an active mental illness?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have a history of addiction to illicit substances?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('If yes, are you in treatment?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have a history of alcohol addiction?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Describe any history of alcohol addiction and recovery:', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What is your occupation?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('I prefer to go to bed between the hours of: ', 2, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('I prefer to wake up between the hours of: ', 2, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What is your daily schedule?', 2, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you usually socialize inside or outside your home?', 2, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What do you do when you have a conflict with someone?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('List 5-7 characteristics in a person that you et along with well?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('In 3-5 sentences, please explain why you want to be a part of the Block Project?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('How do you decompress from a long or challenging day?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, Comment, SurveyId, QuestionTypeId) 
                VALUES ('What skills do you have that you like to do in your free time?',
                        '(e.g. carpentry, mechanic, music, cooking, translation, etc.)', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What are your hobbies?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Please list everyone currently inving in your home:', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('What pets do you have?', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('My pet(s) get along well with: ', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('My pet(s) do NOT get along well with: ', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Generally, how loud are you?', 2, 1)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Have you ever been involved with CPS?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Describe any involvement with CPS:', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Have you ever been detained, arrested, or convicted of a crime?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Do you have any active warrants?', 2, 2)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Describe any active warrant you have: ', 2, 3)");

            Sql(@"INSERT INTO Questions(Text, SurveyId, QuestionTypeId) 
                VALUES ('Please provide 3 references: ', 2, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
