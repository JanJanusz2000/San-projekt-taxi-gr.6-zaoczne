using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    public class District
    {
        public District(int number, string name, int distance)
        {
            Number = number;
            Name = name;
            Distance = distance;
        }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
    }
}

