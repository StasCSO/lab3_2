using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Unit
    {
        private uint health;

        public Unit() { this.health = 10; }

        public Unit(uint a) { this.health = a; }

        public uint Health { get { return health; } set { health = value; } }

        public override string ToString()
        {
            return "Unit health: " + this.health;
        }
    }
}
