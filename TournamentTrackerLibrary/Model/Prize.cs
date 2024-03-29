﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary.Model
{
    public class Prize
    {
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
    }
}
