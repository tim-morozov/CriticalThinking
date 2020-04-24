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
        double availableStorage;
        public List<Applications> applicationsInHD;

        public HardDrive()
        {
            totalStorage = 256;
            availableStorage = 256;
        }
    }
}
