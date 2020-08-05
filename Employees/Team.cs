using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam.Employees
{
    public class Team
    {
        //Constructor
        public Team(string title, int teamid)
        {
            TeamName = title;
            TeamID = teamid;
        }
        public Team(string title, int teamid, List<Developer> developers)
        {
            TeamName = title;
            TeamID = teamid;
            Developers = developers;
        }

        //Properties
        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public List<Developer> Developers { get; set;}
    }
}
