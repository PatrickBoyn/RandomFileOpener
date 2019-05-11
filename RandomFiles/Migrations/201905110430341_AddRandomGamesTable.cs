namespace RandomFiles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRandomGamesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RandomGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullUrl = c.String(),
                        VideoName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateLastAccessed = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RandomGames");
        }
    }
}
