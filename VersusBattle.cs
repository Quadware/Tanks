using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class VersusBattle
    {
        private readonly Tank t1;
        private readonly Tank t2;
        public VersusBattle(Tank _t1, Tank _t2 )
        {
            t1 = _t1;
            t2 = _t2;
        }

        public void Init()
        {
            Console.WriteLine($"\nVersus battle between '{t1.Name}' and '{t2.Name}':\n");
         
            try
            {
                Tank winner = t1 ^ t2;
                Console.Write($"{t1.Points} : {t2.Points}\t");
                Console.WriteLine($"The winner is => { winner.Name}\t({ winner.GetType()})");
            }
            catch (Exception draw)
            {
                Console.Write($"{t1.Points} : {t2.Points}\t");
                Console.WriteLine(draw.Message);
            }
        }
    }
}
