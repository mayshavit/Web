namespace WebServerAndClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientModels", "Password", c => c.String());
            DropColumn("dbo.ClientModels", "Passward");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientModels", "Passward", c => c.String());
            DropColumn("dbo.ClientModels", "Password");
        }
    }
}
