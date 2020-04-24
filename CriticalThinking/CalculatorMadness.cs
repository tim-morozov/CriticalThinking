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
            int expResult = MultiplyTwoNumbers(2, 2);
            int result1 = MultiplyTwoNumbers(40, 35);
            int result2 = DivideTwoNumbers(result1, 4);
            int result3 = AddTwoNumbers(6, 5);
            int result4 = SubtractTwoNumbers(result3, result2);
            int result =  AddTwoNumbers(result4, expResult);

            Console.WriteLine(result);
        }
    }
}
