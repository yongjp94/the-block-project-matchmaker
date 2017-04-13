namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNeighborhoodTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Ballard')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Beacon Hill')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Belltown')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Bitter Lake')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Central District')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Downtown')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Fremont')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Green Lake')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Greenwood')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Lake City')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Laurelhurst')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Magnolia')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Montlake')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Queen Anne')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Rainier Beach')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('South Park')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('University District')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('Wallingford')");
            Sql("INSERT INTO Neighborhoods(Name) VALUES('West Seattle')");
        }
        
        public override void Down()
        {
        }
    }
}
