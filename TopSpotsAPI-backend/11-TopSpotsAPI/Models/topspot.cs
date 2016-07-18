using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_TopSpotsAPI.Models
{
    public class topspot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal[] Location { get; set; }

    }
}