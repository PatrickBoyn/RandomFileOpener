namespace RandomFiles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaxLengthAndChangedTableName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RandomGames", "GameName", c => c.String(maxLength: 30));
            AlterColumn("dbo.RandomGames", "FullUrl", c => c.String(maxLength: 255));
            AlterColumn("dbo.RandomVideos", "FullUrl", c => c.String(maxLength: 255));
            AlterColumn("dbo.RandomVideos", "VideoName", c => c.String(maxLength: 30));
            DropColumn("dbo.RandomGames", "VideoName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RandomGames", "VideoName", c => c.String());
            AlterColumn("dbo.RandomVideos", "VideoName", c => c.String());
            AlterColumn("dbo.RandomVideos", "FullUrl", c => c.String());
            AlterColumn("dbo.RandomGames", "FullUrl", c => c.String());
            DropColumn("dbo.RandomGames", "GameName");
        }
    }
}
