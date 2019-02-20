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
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CurrBench = c.Int(nullable: false),
                        TargBench = c.Int(nullable: false),
                        CurrSquat = c.Int(nullable: false),
                        TargSquat = c.Int(nullable: false),
                        CurrCurl = c.Int(nullable: false),
                        TargCurl = c.Int(nullable: false),
                        CurrLegPress = c.Int(nullable: false),
                        TargLegPress = c.Int(nullable: false),
                        CurrWeight = c.Double(nullable: false),
                        TargWeight = c.Double(nullable: false),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
