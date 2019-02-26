using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessTrackAPI.Models
{
    public class LiftInfo
    {

        [Key]
        public int LiftId { get; set; }

        public int CurrBench { get; set; }
        public int CurrSquat { get; set; }
        public int CurrCurl { get; set; }
        public int CurrLegPress { get; set; }
        public DateTime CurrDate { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

    }
}