using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class ForLoop
    {
        public void FirstLoop()
        {
            for(int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void UserLoop()
        {
            Console.WriteLine("How many times would you like this loop to run?");
            int end = int.Parse(Console.ReadLine());
            for(int i = 0; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void HelloLoop()
        {
            string helloW = "Hello World";
            for(int i = 0; i < helloW.Length; i++)
            {
                Console.WriteLine(helloW[i]);
            }
        }
        
    }
}
