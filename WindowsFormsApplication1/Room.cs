using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS
{
    class Room
    {
        public string name { get; set; }
        public int tier { get; set; }

        public Room(string n, int t)
        {
            this.name = n;
            this.tier = t;
        }

        public void increaseTier()
        {
            this.tier++;
        }
    }
}
