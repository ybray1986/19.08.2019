namespace _19._08._2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Book : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "GenreId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "GenreId");
        }
    }
}
