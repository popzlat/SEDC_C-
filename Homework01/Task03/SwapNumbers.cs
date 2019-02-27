using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Swap two numbers*** ");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine(" ");
            Console.WriteLine("Aftr swaping first number is " + firstNumber + " and the second number is " + secondNumber);
            Console.ReadLine();
        }
    }
}
