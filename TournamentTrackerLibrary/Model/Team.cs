﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary.Model
{
    public class Team
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }
        public Person TeamCaptain { get; set; }
    }
}
