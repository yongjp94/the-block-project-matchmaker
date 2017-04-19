namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAnswerTable : DbMigration
    {
        public override void Up()
        {
            // Answers for 18 Questions
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 1)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 1)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 1)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 1)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 2)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 2)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 2)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 2)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 3)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 3)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 3)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 3)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 4)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 4)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 4)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 4)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 5)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 5)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 5)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 5)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 6)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 6)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 6)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 6)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 7)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 7)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 7)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 7)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 8)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 8)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 8)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 8)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 9)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 9)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 9)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 9)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 10)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 10)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 10)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 10)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 11)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 11)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 11)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 11)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 12)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 12)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 12)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 12)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 13)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 13)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 13)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 13)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 14)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 14)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 14)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 14)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 15)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 15)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 15)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 15)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 16)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 16)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 16)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 16)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 17)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 17)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 17)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 17)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 1', 18)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 2', 18)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 3', 18)");
            Sql("INSERT INTO Answers(Text, QuestionId) VALUES('Choice 4', 18)");

        }
        
        public override void Down()
        {
        }
    }
}
