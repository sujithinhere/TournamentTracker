using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary.Model
{
    public class MatchUp
    {
        public List<MatchUpEntry> Entries { get; set; } = new List<MatchUpEntry>();
        public Team Winner { get; set; }
        public int MatchUpRound { get; set; }
    }
}
