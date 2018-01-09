namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameupdatephone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PhoneNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PhoneNumber");
        }
    }
}
