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

        public double ProcessInstall(double neededStorage, double avStorage)
        {
            double newMem = avStorage - neededStorage;
            return newMem;
        }

        public bool CheckRequirements(double appRAM, double neededStorage, double compRam, double avStorage)
        {
            if(appRAM <= compRam && neededStorage <= avStorage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckGameReq( double gameEffMem, double compEffMem )
        {

            if(gameEffMem <= compEffMem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckGame(string type)
        {
            if(type == "Game")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
