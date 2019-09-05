namespace _19._08._2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Authors",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(maxLength: 100, unicode: false),
            //            LastName = c.String(maxLength: 100, unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Books",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            AuthorId = c.Int(nullable: false),
            //            Title = c.String(nullable: false, maxLength: 150, unicode: false),
            //            Pages = c.Int(),
            //            Price = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Authors", t => t.AuthorId)
            //    .Index(t => t.AuthorId);
            
            //CreateTable(
            //    "dbo.Library",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            UserID = c.Int(nullable: false),
            //            BookID = c.Int(nullable: false),
            //            CreatedDate = c.DateTime(nullable: false, storeType: "date"),
            //            Deadline = c.DateTime(nullable: false, storeType: "date"),
            //            ReturnedDate = c.DateTime(nullable: false, storeType: "date"),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Users", t => t.UserID)
            //    .ForeignKey("dbo.Books", t => t.BookID)
            //    .Index(t => t.UserID)
            //    .Index(t => t.BookID);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            FIO = c.String(nullable: false),
            //            Email = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PicturePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            //DropForeignKey("dbo.Library", "BookID", "dbo.Books");
            //DropForeignKey("dbo.Library", "UserID", "dbo.Users");
            //DropIndex("dbo.Library", new[] { "BookID" });
            //DropIndex("dbo.Library", new[] { "UserID" });
            //DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Genres");
            //DropTable("dbo.Users");
            //DropTable("dbo.Library");
            //DropTable("dbo.Books");
            //DropTable("dbo.Authors");
        }
    }
}
