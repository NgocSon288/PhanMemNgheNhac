namespace MusicWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SongCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDZing = c.String(),
                        CategorySongID = c.Int(nullable: false),
                        DisplayName = c.String(),
                        Title = c.String(),
                        Code = c.String(),
                        ArtistsNames = c.String(),
                        Performer = c.String(),
                        Lyric = c.String(),
                        Thumbnail = c.String(),
                        Duration = c.Int(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SongCategories", t => t.CategorySongID, cascadeDelete: true)
                .Index(t => t.CategorySongID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "CategorySongID", "dbo.SongCategories");
            DropIndex("dbo.Songs", new[] { "CategorySongID" });
            DropTable("dbo.Songs");
            DropTable("dbo.SongCategories");
        }
    }
}
