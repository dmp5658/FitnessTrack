using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessTrackAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*
        public int CurrBench { get; set; }
        public int TargBench { get; set; }
        public int CurrSquat { get; set; }
        public int TargSquat { get; set; }
        public int CurrCurl { get; set; }
        public int TargCurl { get; set; }
        public int CurrLegPress { get; set; }
        public int TargLegPress { get; set; 
        */
        /*
        public double CurrWeight { get; set; }
        public double TargWeight { get; set; }
        */

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB  { get; set; }
        public ICollection<WeightInfo> WeightInfos { get; set; }
        public ICollection<LiftInfo> LiftInfos { get; set; }



    }
}