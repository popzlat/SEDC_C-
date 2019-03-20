using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EnumGender _Gender { get; set; }
        public double AverageGrade { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public Student (string fname , string lname, EnumGender gender , double averageGrade)
        {
            FirstName = fname;
            LastName = lname;
            _Gender = gender;
            AverageGrade = averageGrade;
        }

    }
}
