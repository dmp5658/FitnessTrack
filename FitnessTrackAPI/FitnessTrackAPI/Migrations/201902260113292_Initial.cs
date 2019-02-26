namespace FitnessTrackAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LiftInfoes",
                c => new
                    {
                        LiftId = c.Int(nullable: false, identity: true),
                        CurrBench = c.Int(nullable: false),
                        CurrSquat = c.Int(nullable: false),
                        CurrCurl = c.Int(nullable: false),
                        CurrLegPress = c.Int(nullable: false),
                        CurrDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LiftId)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
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
                "dbo.Targets",
                c => new
                    {
                        TargetId = c.Int(nullable: false, identity: true),
                        TargBench = c.Int(nullable: false),
                        TargSquat = c.Int(nullable: false),
                        TargCurl = c.Int(nullable: false),
                        TargLegPress = c.Int(nullable: false),
                        TargWeight = c.Double(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TargetId)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.WeightInfoes",
                c => new
                    {
                        WeightId = c.Int(nullable: false, identity: true),
                        CurrWeight = c.Double(nullable: false),
                        CurrDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeightId)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LiftInfoes", "UserID", "dbo.Users");
            DropForeignKey("dbo.WeightInfoes", "UserID", "dbo.Users");
            DropForeignKey("dbo.Targets", "UserID", "dbo.Users");
            DropIndex("dbo.WeightInfoes", new[] { "UserID" });
            DropIndex("dbo.Targets", new[] { "UserID" });
            DropIndex("dbo.LiftInfoes", new[] { "UserID" });
            DropTable("dbo.WeightInfoes");
            DropTable("dbo.Targets");
            DropTable("dbo.Users");
            DropTable("dbo.LiftInfoes");
        }
    }
}
