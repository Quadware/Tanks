using System;

namespace Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.MainMenu();


            /************** TEAM BATTLE **************/


            /*
            Battle battle1 = new();
            battle1.Team1 = "White Rose";
            battle1.Team2 = "Red Rose";
            battle1.Init();

            Console.WriteLine("\nShow stats -> press 's' ");
            char key = Console.ReadKey().KeyChar;
            if (key == 's')
            {
                battle1.PrintStat();
            }

            Console.WriteLine("\nStart a new battle -> 'b'");
            key = Console.ReadKey().KeyChar;

            if (key != 'b') { return; }

            Battle battle2 = new("Semen", "Petro", "Ivan", "Andrij", "Vasyl", "Otto", "Adolf", "Hanz", "Fritz", "Klaus");
            battle2.Init();

            Console.WriteLine("\nShow stats -> press 's' ");
            key = Console.ReadKey().KeyChar;
            if (key == 's')
            {
                battle2.PrintStat();
            }
            */

            /************** VERSUS BATTLE **************/

            /*
            T34 t1 = new("T34", 4, 3, 3);
            Panther p1 = new("Panther", 3, 6, 4);

            VersusBattle vb = new(t1, p1);
            vb.Init();
            Console.WriteLine();
            t1.Print();
            Console.WriteLine();
            p1.Print();
            Console.WriteLine();
            */
            
            /************** OTHER CHECK CODE **************/

            //T34 t1 = new();
            //t1.Ammunition = 9;
            //t1.Armour = 12;
            //t1.Mobility = 11;
            //t1.Print();
            //Console.WriteLine();

            //t1.Name = "New Name for T34";
            //t1.Print();
            //Console.WriteLine();

            //T34 t2 = new("Second T34");
            //t2.Print();
            //Console.WriteLine();
            //Panther p1 = new();
            //p1.Print();
            //Console.WriteLine();

            //Panther p2 = new ("Panther2");
            //p2.Print();

            //T34 t1 = new("Ivan");
            //t1.Print();
            //Console.WriteLine();

            //Panther p1 = new("Petro");
            //p1.Print();

        }
    }
}
