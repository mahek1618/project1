using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Stadium
    {
        public int StateId { get; set; }
        public string Statecountry { get; set; }
        public int StateName { get; set; }
        public int NoOfMatchesAllowed { get; set; }
        public int? StateCoId { get; set; }

        public Country StateCo { get; set; }
    }
}
