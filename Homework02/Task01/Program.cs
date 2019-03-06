using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integer no.1: ");
            int number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.2: ");
            int number02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.3: ");
            int number03 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.4: ");
            int number04 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.5: ");
            int number05 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.6: ");
            int number06 = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] myArray = {number01,number02,number03,number04,number05,number06};
            foreach (var number in myArray)
            {
                if (number % 2 == 0)
                {
                     sum += number ;
                }
                
            }
            Console.WriteLine("The sum of the even numbers is : " + sum);

            Console.ReadLine();
        }
    }
}
