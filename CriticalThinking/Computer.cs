using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Computer
    {
        Motherboard motherboard;

        public Computer()
        {
            motherboard = new Motherboard("Asus");
        }
    }
}
