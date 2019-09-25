namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        LastName = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 150, unicode: false),
                        Pages = c.Int(),
                        Price = c.Int(),
                        GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genre", t => t.GenreId)
                .ForeignKey("dbo.Authors", t => t.AuthorId)
                .Index(t => t.AuthorId)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        PicturePath = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Library",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        Deadline = c.DateTime(nullable: false, storeType: "date"),
                        ReturnedDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .ForeignKey("dbo.Books", t => t.BookID)
                .Index(t => t.UserID)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Library", "BookID", "dbo.Books");
            DropForeignKey("dbo.Library", "UserID", "dbo.Users");
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genre");
            DropIndex("dbo.Library", new[] { "BookID" });
            DropIndex("dbo.Library", new[] { "UserID" });
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Users");
            DropTable("dbo.Library");
            DropTable("dbo.Genre");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
