namespace FitnessTrackAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.LiftInfoes",
                c => new
                    {
                        LiftId = c.Int(nullable: false, identity: true),
                        CurrBench = c.Int(nullable: false),
                        TargBench = c.Int(nullable: false),
                        CurrSquat = c.Int(nullable: false),
                        TargSquat = c.Int(nullable: false),
                        CurrCurl = c.Int(nullable: false),
                        TargCurl = c.Int(nullable: false),
                        CurrLegPress = c.Int(nullable: false),
                        TargLegPress = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.LiftId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.WeightInfoes",
                c => new
                    {
                        WeightId = c.Int(nullable: false, identity: true),
                        CurrWeight = c.Double(nullable: false),
                        TargWeight = c.Double(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.WeightId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeightInfoes", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.LiftInfoes", "User_UserId", "dbo.Users");
            DropIndex("dbo.WeightInfoes", new[] { "User_UserId" });
            DropIndex("dbo.LiftInfoes", new[] { "User_UserId" });
            DropTable("dbo.WeightInfoes");
            DropTable("dbo.LiftInfoes");
            DropTable("dbo.Users");
        }
    }
}
