using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalParks.Models
{
    public class education
    {
        public string CITY { get; set; }
        public string ZIP { get; set; }
        public string MAIN { get; set; }
        public string REGION { get; set; }
        public string LOCALE { get; set; }

    }

    public class edu_data
    {
        public string total { get; set; }
        public List<education> data { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
    }
}
