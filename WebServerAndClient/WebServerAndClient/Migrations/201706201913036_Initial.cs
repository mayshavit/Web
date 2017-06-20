namespace WebServerAndClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientModels", "Wins", c => c.Int(nullable: false));
            AddColumn("dbo.ClientModels", "Loses", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientModels", "Loses");
            DropColumn("dbo.ClientModels", "Wins");
        }
    }
}
