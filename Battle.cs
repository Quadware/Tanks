using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    public class Battle
    {
        private readonly T34[] tanksT = new T34[5];
        private readonly Panther[] tanksP = new Panther[5];
        private readonly string[] names = new string[10];
        private string team1 = "T43";
        private string team2 = "Panther";

        public string Team1
        {
            get => team1;
            set => team1 = value;
        }
        public string Team2
        {
            get => team2;
            set => team2 = value;
        }
        public Battle()
        {
            names[0] = "Ivan";
            names[1] = "Vasyl";
            names[2] = "Petro";
            names[3] = "Andrij";
            names[4] = "Semen";
            names[5] = "Adolf";
            names[6] = "Otto";
            names[7] = "Hanz";
            names[8] = "Klaus";
            names[9] = "Fritz";

            for (int i = 0; i < 5; ++i)
            {
                tanksT[i] = new(names[i]);
            }
            for (int i = 5; i < 10; ++i)
            {
                tanksP[i - 5] = new(names[i]);
            }
        }
        public Battle(string _name1, string _name2, string _name3, string _name4, string _name5, string _name6, string _name7, string _name8, string _name9, string _name10)
        {
            tanksT[0] = new(_name1);
            tanksT[1] = new(_name2);
            tanksT[2] = new(_name3);
            tanksT[3] = new(_name4);
            tanksT[4] = new(_name5);
            tanksP[0] = new(_name6);
            tanksP[1] = new(_name7);
            tanksP[2] = new(_name8);
            tanksP[3] = new(_name9);
            tanksP[4] = new(_name10);
        }
        public void Init()
        {
            Console.WriteLine($"\nBattle between: '{team1}' and '{team2}':\n");
            for (int i = 0; i < 5; ++i)
            {
                try
                {
                    Console.Write($"{tanksT[i].Name}\tVS  {tanksP[i].Name}:\t");
                    Tank winner = tanksT[i] ^ tanksP[i];
                    Console.Write($"{tanksT[i].Points} : {tanksP[i].Points}\t");
                    Console.WriteLine($"The winner is => { winner.Name}\t({ winner.GetType()})");
                }
                catch (Exception draw)
                {
                    Console.Write($"{tanksT[i].Points} : {tanksP[i].Points}\t");
                    Console.WriteLine(draw.Message);
                }
            }
        }
        public void PrintStat()
        {
            Console.WriteLine($"\nTeam: {team1}");
            Console.Write("Name:\t\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksT[i].Name}\t");
            }
            Console.Write("\nAmmunition:\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksT[i].Ammunition}\t");
            }
            Console.Write("\nArmour:\t\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksT[i].Armour}\t");
            }
            Console.Write("\nMobility:\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksT[i].Mobility}\t");
            }
            Console.WriteLine($"\n\nTeam: {team2}");
            Console.Write("Name:\t\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksP[i].Name}\t");
            }
            Console.Write("\nAmmunition:\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksP[i].Ammunition}\t");
            }
            Console.Write("\nArmour:\t\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksP[i].Armour}\t");
            }
            Console.Write("\nMobility:\t");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"{tanksP[i].Mobility}\t");
            }
            Console.WriteLine();
        }
    }
}
