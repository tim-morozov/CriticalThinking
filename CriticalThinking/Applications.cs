using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double requiredRAM;
        public double requiredStorage;

        public Applications()
        {
            ApplicationName = "Visual Studio";
            ApplicationType = "IDE";
            requiredRAM = 6;
            requiredStorage = 8.56;
        }
    }
}
