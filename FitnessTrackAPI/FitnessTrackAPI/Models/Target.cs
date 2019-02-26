using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessTrackAPI.Models
{
    public class Target
    {

        [Key]
        public int TargetId { get; set; }

        public int TargBench { get; set; }
        public int TargSquat { get; set; }
        public int TargCurl { get; set; }
        public int TargLegPress { get; set; }
        public double TargWeight { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }




    }
}