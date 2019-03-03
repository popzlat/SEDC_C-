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
         
            if (operaTor != "+" && operaTor != "-"){
                Console.WriteLine("You enter wrong operator");
}
            else{
                switch (operaTor){
                   case "+":
                    result = firstNumber + secondNumber;
                        Console.WriteLine("Result is " + result);
                    break;
                    case "-": 
                    result = firstNumber - secondNumber;
                        Console.WriteLine("Result is " + result);
                    break;
                    case "*":
                    result = firstNumber * secondNumber;
                        Console.WriteLine("Result is " + result);
                    break;
                    case "/":
                    result = firstNumber / secondNumber;
                        Console.WriteLine("Result is " + result);
                    break;

                    default:
                    Console.WriteLine("Please enter the right operator ");
                    break;	}
}

            Console.ReadLine();

        }
    }
}
