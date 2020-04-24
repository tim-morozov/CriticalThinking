using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop myLoop = new ForLoop();
            WhileLoop newLoop = new WhileLoop();
            newLoop.While();
            Console.ReadLine();
        }
    }
}
