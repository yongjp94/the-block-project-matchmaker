namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUserTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes(Id, Name) VALUES(1, 'Resident')");
            Sql("INSERT INTO UserTypes(Id, Name) VALUES(2, 'Host')");
            Sql("INSERT INTO UserTypes(Id, Name) VALUES(3, 'Admin')");

        }
        
        public override void Down()
        {
        }
    }
}
