using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    abstract class Application
    {
        public string ApplicationName;
        public string ApplicationType;
        public double requiredRAM;
        public double requiredStorage;
        public double reqEffectiveMemory;

        public Application()
        {
            
        }
    }
}
