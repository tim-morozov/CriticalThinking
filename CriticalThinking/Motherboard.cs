﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Motherboard
    {
        string manufacturer;
        CPU processor;
        RAM tempMemory;
        HardDrive storage;
        GPU graphics;

        public Motherboard(string manufacturer)
        {
            this.manufacturer = manufacturer;
            processor = new CPU();
            tempMemory = new RAM();
            storage = new HardDrive();
            graphics = new GPU();
        }
    }
}
