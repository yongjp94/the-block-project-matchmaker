namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateLangaugeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Amharic')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('American Sign Language')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Chinese')");

            Sql(@"INSERT INTO Languages(Name)
                  VALUES('English')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('French')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('German')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Hindi')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Japanese')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Korean')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Punjabi')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Russian')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Somali')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Spanish')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Tagalog')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Ukrainian')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Vietnamese')");
            Sql(@"INSERT INTO Languages(Name)
                  VALUES('Other')");
        }

        public override void Down()
        {
            DropTable("dbo.Languages");
        }
    }
}
