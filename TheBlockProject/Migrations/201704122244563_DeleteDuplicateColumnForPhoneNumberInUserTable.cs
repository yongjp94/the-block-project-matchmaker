namespace TheBlockProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDuplicateColumnForPhoneNumberInUserTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "PhoneNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNum", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
        }
    }
}
