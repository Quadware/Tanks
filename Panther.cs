using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Panther : Tank
    {
        public Panther() : base(nameof(Panther)) { }
        public Panther(string _name) : base(_name) { }

        public Panther(string _name, ushort _ammunition, ushort _armour, ushort _mobility) : base(_name, _ammunition, _armour, _mobility) { }
    }
}
