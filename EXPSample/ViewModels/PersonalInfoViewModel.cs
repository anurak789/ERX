using EXPSample.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EXPSample.ViewModels
{
    public class PersonalInfoViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Title> Titles { get; set; }
        [Display(Name = "Title")]
        public string StrTitle { get; set; }
        [Display(Name = "First name")]
        public string Firstname { get; set; }
        [Display(Name = "Last name")]
        public string Lastname { get; set; }
        [Display(Name = "Date Of Birth (MM/dd/yyy)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<CountryInTheWorld> CountryRess { get; set; }
        [Display(Name = "Country of Residence")]
        public string StrCountry { get; set; }
        [Display(Name = "House Address")]
        public string HouseAddress { get; set; }
        [Display(Name = "Work Address")]
        public string WorkAddress { get; set; }
        public IEnumerable<Occupation> Occupations { get; set; }
        [Display(Name = "Occupation")]
        public string StrOccupation { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        public IEnumerable<BusinessType> BusinessTypes { get; set; }
        [Display(Name = "Business Type")]
        public string StrBusinessType { get; set; }
    }
}
