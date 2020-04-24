using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class HardDrive
    {
        double totalStorage;
        public double availableStorage;
        public List<Application> applicationsInHD;

        public HardDrive()
        {
            totalStorage = 256;
            availableStorage = totalStorage;
            applicationsInHD = new List<Application>();
        }
    }
}
