using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int NumberOfEggs { get; set; }
        public bool HasScales { get; set; }
        public bool LivesOnLand { get; set; }
        public bool LivesInWater { get; set; }


    }
}
