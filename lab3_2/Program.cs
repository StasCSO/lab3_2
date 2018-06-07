using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse(30, 40);
            Console.WriteLine(horse.ToString());

            Soldier soldier = new Soldier(50, 30);
            Console.WriteLine(soldier.ToString());

            Unit unit = new Unit();
            Console.WriteLine(unit);

            unit = horse; // so you can do
            Console.WriteLine(unit);

            unit = soldier; // so you can do
            Console.WriteLine(unit);

            horse = (Horse)unit; // So it is impossible to do. Will be error

        }
    }
}
