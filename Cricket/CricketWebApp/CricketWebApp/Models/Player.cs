using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public int PlayerCoId { get; set; }

        public Country PlayerCo { get; set; }
    }
}
