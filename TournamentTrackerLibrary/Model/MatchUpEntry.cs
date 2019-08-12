using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary.Model
{
    public class MatchUpEntry
    {
        public Team TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchUp ParentMatchUp { get; set; }
    }
}
