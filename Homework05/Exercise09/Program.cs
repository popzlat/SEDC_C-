using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Kristijan", "Spirov", EnumGender.Male, 9.5);
            Student student2 = new Student("Bojan", "Ilev", EnumGender.Male, 6.2);
            Student student3 = new Student("Ivana", "Nakeva", EnumGender.Female, 8.5);
            Student student4 = new Student("Antonio", "Delev", EnumGender.Male, 2.9);
            Student student5 = new Student("Biljana", "Arsova", EnumGender.Female, 7.2);
            Student student6 = new Student("Angelina", "Gerovska", EnumGender.Female, 4.7);
            Student student7 = new Student("Silvija", "Bashovska", EnumGender.Female, 7.0);
            Student student8 = new Student("Adrijan", "Gigov", EnumGender.Male, 9.0);
            Student student9 = new Student("Simona", "Aneva", EnumGender.Female, 10.0);
            Student student10 = new Student("Ilina", "Spirkovska", EnumGender.Female, 5.6);
            List<Student> class1 = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };
            Student student11 = new Student("Gorjan", "Kirov", EnumGender.Male, 8.0);
            Student student12 = new Student("Vasko", "Pecov", EnumGender.Male, 7.6);
            Student student13 = new Student("Ivona", "Zdravevska", EnumGender.Female, 9.0);
            Student student14 = new Student("Lara", "Ivevska", EnumGender.Female, 5.9);
            Student student15 = new Student("Boris", "Savevski", EnumGender.Male, 7.0);
            Student student16 = new Student("Slavko", "Topuzov", EnumGender.Male, 3.5);
            Student student17 = new Student("Tijana", "Ickovska", EnumGender.Female, 4.6);
            Student student18 = new Student("Gorjan", "Petrevski", EnumGender.Male, 8.4);
            Student student19 = new Student("Vedran", "Mackov", EnumGender.Male, 9.8);
            Student student20 = new Student("Mirka", "Andreevska", EnumGender.Female, 6.0);
            List<Student> class2 = new List<Student>() { student11, student12, student13, student14, student15, student16, student17, student18, student19, student20 };

            try
            {
                List<Student> courentClass = new List<Student>();
                Console.WriteLine("Pick a class \n 1)class 1 \n 2)class 2");
                string pickClass = Console.ReadLine();
                if (pickClass == "1")
                {
                    courentClass = class1;
                    Console.WriteLine("You pick the  class 1 \n ");
                }
                else if (pickClass == "2")
                {
                    courentClass = class2;
                    Console.WriteLine("You pick the  class 2 \n ");
                }
                else
                {
                    throw new Exception("Pick 1 or 2 ...!!");
                }
                Console.WriteLine("OK .. now choose an action: \n ");
                Console.WriteLine("1)Print all female students \n");
                Console.WriteLine("2)Print all male students  \n");
                Console.WriteLine("3)Print all students with a first letter of a name \n");
                Console.WriteLine("4)Print all students with a grade higher than input \n");
                Console.WriteLine("5)Print the Average of all students AverageGrade in the class  \n");
                string pickAction = Console.ReadLine();

                switch (pickAction)
                {
                    case "1":
                      var females = courentClass.Where(x => x._Gender == EnumGender.Female).ToList();
                        foreach (var item in females)
                        {
                            item.PrintInfo();
                        }
                        break;
                    case "2":
                        var males = courentClass.Where(x => x._Gender == EnumGender.Male).ToList();
                        foreach (var item in males)
                        {
                            item.PrintInfo();
                        }
                        break;
                    case "3":
                        string firstLetter = Console.ReadLine().ToUpper();
                        var firstLetterStartsWith = courentClass.Where(x => x.FirstName.StartsWith(firstLetter)).ToList();
                        foreach (var item in firstLetterStartsWith)
                        {
                            item.PrintInfo();
                        }

                        break;
                    case "4":
                        Console.WriteLine("Input a grade sepaate by ',' ");
                        double inputGrade = double.Parse(Console.ReadLine());
                        var higherThanInput = courentClass.Where(x => x.AverageGrade >= inputGrade).ToList();
                        foreach (var item in higherThanInput)
                        {
                            item.PrintInfo();
                        }
                        break;
                    case "5":
                        double sum = 0;
                        Console.WriteLine($"The Average of all students AverageGrade in this class is : ");
                        var average = courentClass.Select(x => x.AverageGrade).ToList();

                        foreach (var item in average)
                        {
                            sum += item;
                        }
                           sum =  sum / 10;
                        Console.WriteLine(sum);

                        break;

                    default:
                        throw new Exception("you pick wrong action .. try again later !");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }







            Console.ReadLine();
        }
    }
}
