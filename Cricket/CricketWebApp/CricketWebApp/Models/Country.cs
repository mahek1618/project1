using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Country
    {
        public Country()
        {
            Player = new HashSet<Player>();
            State = new HashSet<Stadium>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public string CountryCode { get; set; }

        public ICollection<Player> Player { get; set; }
        public ICollection<Stadium> State { get; set; }
    }
}
