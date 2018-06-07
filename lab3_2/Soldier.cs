using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Soldier : Unit
    {
        private uint damage;

        public Soldier() { this.damage = 20; }

        public Soldier(uint a) : base(a) { }

        public Soldier(uint a, uint b) : base(a) { this.damage = b; }

        public uint Damage { get { return damage; } set { this.damage = value; } }

        public override string ToString()
        {
            return "Sodier damage: " + this.damage + "; Sodier health: " + this.Health;
        }
    }
}
