namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assassins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Busy = c.Boolean(nullable: false),
                        RewardMin = c.Int(nullable: false),
                        RewardMax = c.Int(nullable: false),
                        WelcomingMessage = c.String(nullable: false),
                        KillingMessage = c.String(nullable: false),
                        PlayingMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Beggars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fee = c.Double(nullable: false),
                        WelcomingMessage = c.String(nullable: false),
                        KillingMessage = c.String(nullable: false),
                        PlayingMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fee = c.Double(nullable: false),
                        WelcomingMessage = c.String(nullable: false),
                        KillingMessage = c.String(nullable: false),
                        PlayingMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ThievesGuilds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Thefts = c.Int(nullable: false),
                        Fee = c.Int(nullable: false),
                        WelcomingMessage = c.String(nullable: false),
                        KillingMessage = c.String(nullable: false),
                        PlayingMessage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThievesGuilds");
            DropTable("dbo.Fools");
            DropTable("dbo.Beggars");
            DropTable("dbo.Assassins");
        }
    }
}
