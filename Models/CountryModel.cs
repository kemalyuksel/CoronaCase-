using System;
using System.Net.Http;

namespace CoronaApi.Models
{
    public class CountryModel
    {
        public string country { get; set; }
        public float cases { get; set; }
        public float todayCases { get; set; }
        public float todayDeaths { get; set; }
        public float deaths { get; set; }
        public float recovered { get; set; }
        public float active { get; set; }
        public float critical { get; set; }
        public int totalTests { get; set; }




    }
}