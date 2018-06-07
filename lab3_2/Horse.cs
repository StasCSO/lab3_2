using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Horse : Unit
    {
        private uint speed;

        public Horse() { this.speed = 20; }

        public Horse(uint a) : base(a) { }

        public Horse(uint a, uint b) : base(a) { this.speed = b; }

        public uint Speed { get { return speed; } set { this.speed = value; } }

        public override string ToString()
        {
            return "Horse speed: " + this.speed + "; Horse health: " + this.Health;
        }

    }
}
