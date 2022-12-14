using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    class Population
    {
        public int x;
        public int survival_rate;
        public double survival_percent;
        public Population(int number, int rate)
        {
            x = number;
            survival_rate = rate;
        }
    }
}
