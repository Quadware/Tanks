using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    abstract class Tank
    {
        protected string name;
        protected int ammunition;
        protected int armour;
        protected int mobility;
        protected int points;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Ammunition
        {
            get => ammunition;
            set => ammunition = value;
        }
        public int Armour
        {
            get => armour;
            set => armour = value;
        }
        public int Mobility
        {
            get => mobility;
            set => mobility = value;
        }
        public int Points
        {
            get => points;
        }
        public Tank(string _name)
        {
            name = _name;
            Random rand = new();
            ammunition = rand.Next(0, 100);
            armour = rand.Next(0, 100);
            mobility = rand.Next(0, 100);
            points = 0;
        }
        public Tank(string _name, int _ammunition, int _armour, int _mobility )
        {
            name = _name;
            ammunition = _ammunition;
            armour = _armour;
            mobility = _mobility;
            points = 0;
        }
        public static Tank operator ^ (Tank a, Tank b)
        {
            if (a.ammunition > b.ammunition)
            {
                ++a.points;
            }
            else if (a.ammunition < b.ammunition)
            {
                ++b.points;
            }
            if (a.armour > b.armour)
            {
                ++a.points;
                if (a.points == 2) { return a; }
            }
            else if (a.armour < b.armour)
            {
                ++b.points;
                if (b.points == 2) { return b; }
            }
            if (a.mobility > b.mobility)
            {
                ++a.points;
                if (a.points == 2) { return a; }
            }
            else if (a.mobility < b.mobility)
            {
                ++b.points;
                if (b.points == 2) { return b; }
            }
            throw new Exception("It's a DRAW!");
        }
        public void Print()
        {
            Console.WriteLine($"Name:\t\t{Name}");
            Console.WriteLine($"Ammunition:\t{ammunition}");
            Console.WriteLine($"Armour:\t\t{armour}");
            Console.WriteLine($"Mobility:\t{mobility}");
        }
    }
}
