using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gurukul.Models
{
    public class SearchResultModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Taluka { get; set; }
        public string dist { get; set; }
        public int standard { get; set; }
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
        public DateTime DOB { get; set; }
    }
}