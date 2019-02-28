using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class AverageNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average of " + firstNumber +" " + secondNumber + " "+ thirdNumber + " "+ fourthNumber + " is " + average);
            Console.ReadLine();
        }
    }
}
