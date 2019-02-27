namespace FitnessTrackAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FitnessTrackAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FitnessTrackAPI.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Targets.Add(new Models.Target() { TargBench = 250, TargCurl = 200, TargLegPress = 400, TargSquat = 200, TargWeight = 175, UserID =1 });
            context.WeightInfos.Add(new Models.WeightInfo() { CurrWeight = 200, UserID = 1, CurrDate = DateTime.Now });
            context.LiftInfos.Add(new Models.LiftInfo() { CurrBench = 200, CurrCurl = 140, CurrDate = DateTime.Now, CurrLegPress = 300, CurrSquat = 0, UserID = 1 });
              
        }
    }
}
