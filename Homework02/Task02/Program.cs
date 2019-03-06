using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentG1 = {"Zlatko","Dejan","Marko" , "Nikola", "NeoGeo"};
            string[] studentG2 = {"Petko","Stanko","Rajko","Branko","Trajko" };
            Console.WriteLine("Enter a number (1 or 2 )");

            int number = int.Parse(Console.ReadLine());
            if(number != 1 && number != 2)
            {
                Console.WriteLine("Please enter the correct number ");
               
            }

            else if(number == 1)
            {
                Console.WriteLine("The students in G1 are : ");
                foreach (var students in studentG1)
                {
                    
                    Console.WriteLine(students);
                }

            }
            else
            {
                Console.WriteLine("The students in G2 are : ");
                foreach (var students in studentG2)
                {
                    Console.WriteLine(students);
                }
            }


            Console.ReadLine();


        }
    }
}
