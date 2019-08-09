namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "GenreId", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "GenreId" });
            DropColumn("dbo.Customers", "GenreId");
            DropColumn("dbo.Customers", "DateAdded");
            DropColumn("dbo.Customers", "ReleaseDate");
            DropColumn("dbo.Customers", "NumberInStock");
            DropColumn("dbo.Customers", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "NumberInStock", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "GenreId");
            AddForeignKey("dbo.Customers", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
