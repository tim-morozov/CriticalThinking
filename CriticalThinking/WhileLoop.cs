using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class WhileLoop
    {
        public void While()
        {
            int counter = 0;
            while(counter != 42)
            {
                Console.WriteLine("Please enter the number 42");
                 counter = int.Parse(Console.ReadLine());
            }
        }
    }
}
