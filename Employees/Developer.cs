using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam.Employees
{
    public class Developer
    {
        //Constructor
        public Developer(int id, string lastname, bool hasps)
        {
            ID = id;
            LastName = lastname;
            HasPluralSight = hasps;
        }

        //Properties
        public int ID { get; set; }
        public string LastName { get; set; }
        public bool HasPluralSight { get; set; }
        public int TeamIDIndividual { get; set; }
    }
}
