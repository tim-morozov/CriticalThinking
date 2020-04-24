using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CPU
    {
        string manufacturer;
        string name;

        public CPU()
        {
            manufacturer = "intel";
            name = "i5";
        }

        public void ProcessInstall()
        {

        }

        public void CheckRequirements(double appRAM, double neededStorage, double compRam, double avStorage)
        {
            if(appRAM <= compRam && neededStorage <= avStorage)
            {
                Console.WriteLine("You may install!");
            }
            else
            {
                Console.WriteLine("You may not install!");
            }
        }
    }
}
