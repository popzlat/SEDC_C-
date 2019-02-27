using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class realCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What operation would like to be done (+, - , * , /)");
           string operaTor = Console.ReadLine();
            int result = 0;
            if(operaTor == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operaTor == "-")
            {
                result = firstNumber - secondNumber;
            }
             if (operaTor == "*")
            {
                result = firstNumber * secondNumber;
            }
             if (operaTor == "/")
            {
                result = firstNumber / secondNumber;
            }

            Console.WriteLine("The result is : " + result);
            Console.ReadLine();

        }
    }
}
