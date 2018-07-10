namespace DVDStore.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.String(),
                        YearReleased = c.Int(nullable: false),
                        RunTime = c.String(),
                        TotalSalesCount = c.Single(nullable: false),
                        Summary = c.String(),
                        Rating = c.String(),
                        Cover = c.Binary(),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DVDActors",
                c => new
                    {
                        DVD_ID = c.Int(nullable: false),
                        Actor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DVD_ID, t.Actor_ID })
                .ForeignKey("dbo.DVDs", t => t.DVD_ID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ID, cascadeDelete: true)
                .Index(t => t.DVD_ID)
                .Index(t => t.Actor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DVDs", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.DVDActors", "Actor_ID", "dbo.Actors");
            DropForeignKey("dbo.DVDActors", "DVD_ID", "dbo.DVDs");
            DropIndex("dbo.DVDActors", new[] { "Actor_ID" });
            DropIndex("dbo.DVDActors", new[] { "DVD_ID" });
            DropIndex("dbo.DVDs", new[] { "GenreID" });
            DropTable("dbo.DVDActors");
            DropTable("dbo.Genres");
            DropTable("dbo.DVDs");
            DropTable("dbo.Actors");
        }
    }
}
