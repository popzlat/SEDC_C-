using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFromClass04
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.AddDays(3));
            Console.WriteLine(thisDay.AddMonths(1));
            Console.WriteLine(thisDay.AddDays(3).AddMonths(1));
            Console.WriteLine(thisDay.AddYears(-1).AddMonths(-2));
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            
            
            

            Console.ReadLine();
        }
    }
}
