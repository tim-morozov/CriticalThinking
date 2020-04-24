using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Game : Application
    {
      
        public Game(string applicationName, string applicationType, double reqRAM, double reqSto, double reqEffect)
        {
            ApplicationName = applicationName;
            ApplicationType = applicationType;
            requiredRAM = reqRAM;
            requiredStorage = reqSto;
            reqEffectiveMemory = reqEffect;
        }
    }
}
