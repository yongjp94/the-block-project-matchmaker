namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenderTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders(Id, Name) VALUES(1, 'Male')");
            Sql("INSERT INTO Genders(Id, Name) VALUES(2, 'Female')");
            Sql("INSERT INTO Genders(Id, Name) VALUES(3, 'Non-binary/3rd gender')");
            Sql("INSERT INTO Genders(Id, Name) VALUES(4, 'Other')");
            Sql("INSERT INTO Genders(Id, Name) VALUES(5, 'Prefer not to say')");

        }
        
        public override void Down()
        {
        }
    }
}
