using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CalculatorMadness
    {
        public void AddTwoNumbers()
        {
            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = firstNumber + secondNumber;
            Console.WriteLine("The result of this addition is: " + result);
        }
    }
}
