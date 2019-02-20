using FitnessTrackAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitnessTrackAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=FitnessTrackDb")
        {

        }

        public DbSet<User> Users { get; set; }

    }
}