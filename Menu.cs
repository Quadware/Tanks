using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Menu
    {
        public static char key = 'a';

        public static void MainMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n* * * * * WELCOME TO WOLRD OF TANKS * * * * *\n");
                Console.WriteLine("Select a battle type:\n\n 1 - Versus battle\n 2 - Multiplayer\n\nPress 'x' to exit");
                key = Console.ReadKey().KeyChar;
                Console.Clear();

                if (key == '1')
                {
                    T34 t1 = new("T34", 4, 3, 3);
                    Panther p1 = new("Panther", 3, 6, 4);
                    VersusBattle vb = new(t1, p1);

                    Console.WriteLine();
                    t1.Print();
                    Console.WriteLine();
                    p1.Print();
                    Console.WriteLine();

                    Console.WriteLine("Press b to start battle\n");
                    key  = Console.ReadKey().KeyChar;

                    if (key == 'b') { vb.Init(); }

                    Console.WriteLine("\n\nPress any key to go to the main menu");
                    Console.ReadLine();
                }
                if (key == '2')
                {
                    Battle battle1 = new();
                    battle1.Team1 = "White Rose";
                    battle1.Team2 = "Red Rose";
                    battle1.Init();

                    Console.WriteLine("\nShow stats -> press 's' ");
                    key = Console.ReadKey().KeyChar;
                    if (key == 's')
                    {
                        battle1.PrintStat();
                    }

                    Console.WriteLine("\nStart a new battle -> 'b'");
                    key = Console.ReadKey().KeyChar;

                    if (key == 'b')
                    {
                        Battle battle2 = new("Semen", "Petro", "Ivan", "Andrij", "Vasyl", "Otto", "Adolf", "Hanz", "Fritz", "Klaus");
                        battle2.Init();

                        Console.WriteLine("\nShow stats -> press 's'\nAny other key - Main menu\n'x' to exit\n");
                        key = Console.ReadKey().KeyChar;

                        if (key == 's')
                        {
                            battle2.PrintStat();
                            Console.WriteLine("\nPress any key to go to the main menu");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPress any key to go to the main menu");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("'x' was pressed. Exiting...");
            }
            while (key != 'x');
        }
    }
}
