using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10
{
    public class Team
    {

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }

        public virtual List<Player> Players { get; set; }

    }

    public class Player
    {

        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team {get;set;}

    }

}
