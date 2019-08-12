using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary.Model
{
    public class Tournament
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<Team> EnteredTeams { get; set; } = new List<Team>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        public List<List<MatchUp>> Rounds { get; set; } = new List<List<MatchUp>>();
    }
}
