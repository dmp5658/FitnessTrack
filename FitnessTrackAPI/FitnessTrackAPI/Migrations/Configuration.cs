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
            context.Users.Add(new Models.User() { UserName = "user", Password = "pass", FirstName = "first", LastName = "last", CurrBench = 0, CurrCurl = 0, CurrLegPress = 0, CurrSquat = 0, CurrWeight = 0, TargBench = 0, TargCurl = 0, TargLegPress = 0, TargSquat = 0, TargWeight = 0, DOB = new DateTime(2008, 3, 1) });
        }
    }
}
