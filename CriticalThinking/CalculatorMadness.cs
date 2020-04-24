using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CalculatorMadness
    {
        private int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("The result of this addition is: " + result);
            return result;
        }

        private int SubtractTwoNumbers(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }
        private int MultiplyTwoNumbers(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }

        private int DivideTwoNumbers(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            return result;
        }

        public void RunCalculations()
        {
            
           int result1 = AddTwoNumbers(8, 40);
           int result2 =AddTwoNumbers(200, 50);
           int result = AddTwoNumbers(result1, result2);
            Console.WriteLine(result);
        }
    }
}
