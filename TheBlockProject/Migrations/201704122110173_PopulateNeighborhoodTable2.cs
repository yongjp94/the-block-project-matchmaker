namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNeighborhoodTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Races(Id, Name) VALUES(7, 'Middle Eastern or North African')");
            Sql("INSERT INTO Races(Id, Name) VALUES(8, 'Prefer not to say')");
        }
        
        public override void Down()
        {
        }
    }
}
