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

        public void InstallApplication(Application newApp)
        {
            bool game = processor.CheckGame(newApp.ApplicationType);
            if (game == true)
            {
                InstallGame(newApp);
            }
            else
            {
                bool install = processor.CheckRequirements(newApp.requiredRAM, newApp.requiredStorage, tempMemory.totalGB, storage.availableStorage);

                if (install = true)
                {
                    processor.ProcessInstall(newApp.requiredStorage, storage.availableStorage);
                    storage.applicationsInHD.Add(newApp);
                    Console.WriteLine(newApp.ApplicationName + " installed!");
                }
                else
                {
                    Console.WriteLine("You may not install");
                }
            }
        }
        public void InstallGame(Application newGame)
        {
            bool install = processor.CheckGameReq(newGame.reqEffectiveMemory, graphics.effectiveMemory);
            install = processor.CheckRequirements(newGame.requiredRAM, newGame.requiredStorage, tempMemory.totalGB, storage.availableStorage);

            if (install = true)
            {
                processor.ProcessInstall(newGame.requiredStorage, storage.availableStorage);
                storage.applicationsInHD.Add(newGame);
                Console.WriteLine(newGame.ApplicationName + " installed!");
            }
            else
            {
                Console.WriteLine("You may not install");
            }
        }
    }
}
