using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EXPSample.Data
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "First name")]
        public string Firstname { get; set; }
        [Display(Name = "Last name")]
        public string Lastname { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Country of Residence")]
        public string CountryRes { get; set; }
        [Display(Name = "House Address")]
        public string HouseAddress { get; set; }
        [Display(Name = "Work Address")]
        public string WorkAddress { get; set; }
        public string Occupation { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name = "Business Type")]
        public string BusinessType { get; set; }
    }
}
