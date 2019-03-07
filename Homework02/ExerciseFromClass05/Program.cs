using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFromClass05
{
    class Program
    {
        static DateTime AgeCalculator(DateTime dateOfBirth)
        {
            DateTime currentTime = DateTime.Now;

            TimeSpan timeSpan = currentTime - dateOfBirth;

            DateTime age = DateTime.MinValue + timeSpan;

            return age;
        }

        private static void Main(string[] args)
        {
            string day, month, year;

            Console.WriteLine("Please enter your date of birth :");
            Console.WriteLine("Day:");
            day = Console.ReadLine();

            Console.WriteLine("Month:");
            month = Console.ReadLine();

            Console.WriteLine("Year:");
            year = Console.ReadLine();

            DateTime dateOfBirth = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            DateTime age = AgeCalculator(dateOfBirth);

            int years = age.Year - 1;
            int months = age.Month - 1;
            int days = age.Day - 1;

            Console.WriteLine(years.ToString() + (years > 1 ? " Years " : " Year ") +
                months.ToString() + (months > 1 ? " Months " : " Month ") +
                days.ToString() + (days > 1 ? " Days" : " Day"));
            Console.WriteLine("You are " + years + " years old");
            Console.Read();
        }

         
    }
}
