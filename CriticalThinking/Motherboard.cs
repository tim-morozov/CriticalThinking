using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Motherboard
    {
        public string manufacturer;
        public CPU processor;
        public RAM tempMemory;
        public HardDrive storage;
        public GPU graphics;

        public Motherboard(string manufacturer)
        {
            this.manufacturer = manufacturer;
            processor = new CPU();
            tempMemory = new RAM();
            storage = new HardDrive();
            graphics = new GPU();
        }

        public void InstallApplication(Applications newApp)
        {
            bool install = processor.CheckRequirements(newApp.requiredRAM, newApp.requiredStorage, tempMemory.totalGB, storage.availableStorage);
            if (install = true)
            {
                processor.ProcessInstall(newApp.requiredStorage, storage.availableStorage);
                storage.applicationsInHD.Add(newApp);
                Console.WriteLine("Application installed!");
            }
            else
            {
                Console.WriteLine("You may not install");
            }
        }
    }
}
