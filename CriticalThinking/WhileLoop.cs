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
            Console.WriteLine("Where would you like to start? (must be less than 25)");
            int counter = int.Parse(Console.ReadLine());
            while(counter < 25)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
