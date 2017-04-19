namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSurveyDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Surveys(Id, Name) VALUES(1, 'Resident')");
            Sql("INSERT INTO Surveys(Id, Name) VALUES(2, 'Host')");
            Sql("INSERT INTO Surveys(Id, Name) VALUES(3, 'Both')");
        }
        
        public override void Down()
        {
        }
    }
}
