using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSY.Models
{
    public class Demand
    {
        [Display(Name = "Job Card / जॉब कार्ड संख्या ")]
        [Required]
        public string jobCardNumber { get; set; }

        [Display(Name = "Aadhaar No./ आधार नंबर ")]
        [Required]
        public string adhar_no { get; set; }

        [Display(Name = "Demand Days/ कार्य के दिनों की मांग ")]
        [Required]
        public int demand_day { get; set; }


    }
}