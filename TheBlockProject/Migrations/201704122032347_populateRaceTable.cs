namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateRaceTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Races(Id, Name) VALUES(1, 'American Indian or Alaska Native')");
            Sql("INSERT INTO Races(Id, Name) VALUES(2, 'Asian')");
            Sql("INSERT INTO Races(Id, Name) VALUES(3, 'Black or African American')");
            Sql("INSERT INTO Races(Id, Name) VALUES(4, 'Hispanic or Latino')");
            Sql("INSERT INTO Races(Id, Name) VALUES(5, 'Native Hawaiian or Other Pacific Islander')");
            Sql("INSERT INTO Races(Id, Name) VALUES(6, 'White')");
        }
        
        public override void Down()
        {
        }
    }
}
