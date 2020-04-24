using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class TextEdit : Application
    {
        public TextEdit(string applicationName, string applicationType, double reqRAM, double reqSto)
        {
            ApplicationName = applicationName;
            ApplicationType = applicationType;
            requiredRAM = reqRAM;
            requiredStorage = reqSto;
        }
    }
}
