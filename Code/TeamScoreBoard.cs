using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz
{
    public class TeamScoreBoardWrapper
    {
        public Dictionary<Team,Int32> teamScores;
        private int index;
        public TeamScoreBoardWrapper ()
        {
            index = 0;
            teamScores = new Dictionary<Team, int>();
            teamScores.Add(new Team { Name = "Team A", index = this.index++ }, 5);
            teamScores.Add(new Team { Name = "Team B", index = this.index++ }, 10);
            teamScores.Add(new Team { Name = "Team C", index = this.index++ }, 15);
        }
    }

    public class Team
    {
        public String Name;
        public int index;
    }
}
