using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessTrackAPI.Models
{
    public class WeightInfo
    {
        [Key]
        public int WeightId { get; set; }

        public double CurrWeight { get; set; }
        public double TargWeight { get; set; }
        public User User { get; set; }

    }
}