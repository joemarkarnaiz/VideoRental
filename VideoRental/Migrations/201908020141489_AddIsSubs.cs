namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "IsSubscribedToNewletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "IsSubscribedToNewletter");
        }
    }
}
