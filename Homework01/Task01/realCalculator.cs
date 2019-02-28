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
            
            if(operaTor != "+" && operaTor != "-" && operaTor != "*" && operaTor != "/"){
            switch(operaTor){
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                    case "-": 
                    result = firstNumber - secondNumber;
                    break;
                    case "*":
                    result = firstNumber * secondNumber;
                    break;
                    case "/":
                    result = firstNumber / secondNumber;
                    break;

                    default:
                    Console.WriteLine("Please enter the right operator ");
                    break;

                    }
                }
            else{
                Console.WriteLine("Something went wrong try again");
}               


            Console.ReadLine();

        }
    }
}
