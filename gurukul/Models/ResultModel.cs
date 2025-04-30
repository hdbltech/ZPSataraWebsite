using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gurukul.Models
{
    public class ResultModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "कृपया संपूर्ण माहिती भरा")]
        [Display(Name = "तालुका")]
        public string Taluka { get; set; }

        [Required(ErrorMessage = "कृपया संपूर्ण माहिती भरा")]
        [Display(Name = "जिल्हा")]
        public string dist { get; set; }

        [Required(ErrorMessage = "कृपया संपूर्ण माहिती भरा")]
        [Display(Name = "इयत्ता")]
        public int standard { get; set; }

        [Required(ErrorMessage = "कृपया संपूर्ण माहिती भरा")]
        [Display(Name = "परीक्षा क्रमांक")]
        public int rollnumber { get; set; }
        public string barcode1 { get; set; }
        public string barcode2 { get; set; }
        public int Correctans1 { get; set; }
        public int Correctans2 { get; set; }
        public int Total { get; set; }
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int StateRank { get; set; }
        public int DistaRank { get; set; }
        public int TalukaRank { get; set; }
        public double Percentage { get; set; }
        public string schoolname { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime DOB { get; set; }
    }
}