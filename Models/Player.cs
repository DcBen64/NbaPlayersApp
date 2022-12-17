using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaPlayersApp.Models
{
    public class Player
    {
        public int Id { get; set; }

        public String team { get; set; }

        public String fname { get; set; }

        public String lname { get; set; }

        public double ppg { get; set; }

        public double apg { get; set; }

        public double rpg { get; set; }

        public Player()
        {

        }

    }
}
