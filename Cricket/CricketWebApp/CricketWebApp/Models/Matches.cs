﻿using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Matches
    {
        public int MatchId { get; set; }
        public int MatchStId { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string Result { get; set; }
        public DateTime DateTime { get; set; }
        public int? WasMatchPlayed { get; set; }
    }
}
