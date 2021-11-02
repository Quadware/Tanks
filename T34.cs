using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class T34 : Tank
    {
        public T34() : base(nameof(T34)) { }
        public T34(string _name) : base(_name) { }

        public T34(string _name, ushort _ammunition, ushort _armour, ushort _mobility) : base(_name, _ammunition, _armour, _mobility) { }
    }
}
