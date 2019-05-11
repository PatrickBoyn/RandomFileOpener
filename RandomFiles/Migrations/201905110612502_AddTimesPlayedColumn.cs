namespace RandomFiles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimesPlayedColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RandomVideos", "TimesPlayed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RandomVideos", "TimesPlayed");
        }
    }
}
