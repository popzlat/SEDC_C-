using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise03.CostumersFile;
namespace Exercise03
{
   public class Program
    {
        static void Main(string[] args)
        {
            bool newTransaction = true;

            string costumerChoise;
            

            string costumerFound;
          
            Costumers[] arr =
           {
                new Costumers("Zlatko Poposki","1234-1234-1234-1234","1234",500),
                new Costumers("Petko Petkov","0000-0000-0000-0000","0000",250),
                new Costumers("Stanko Stankov","1111-1111-1111-1111","1111",780),
                new Costumers("Trajce Trajkov","2222-2222-2222-2222","2222",360),

            };

            
            while (newTransaction)
            {

            
            Console.WriteLine("Welcome to the ATM application ");
            Console.WriteLine("");
            Console.WriteLine("Please enter your card numer:");

            string card = Console.ReadLine();
            

            Costumers foundC = null;

            string pin;
            bool rightPin = false;

            foreach (var item in arr)
            {
                if (item.CardNumer == card)
                {
                    costumerFound = item.Username;
                    foundC = item;
                    Console.WriteLine("Please enter your pin");
                     pin = Console.ReadLine();
                    if (item.Pin == pin)
                    {
                        rightPin = true;
                        Console.WriteLine($"Wellcome {costumerFound }!");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("You enter wrong pin !");
                            
                    }

                }
              

            }
                if (foundC == null)
                {
                    Console.WriteLine("User not found");
                }
            if (rightPin == true)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine($" 1.Check Balance \n 2.Cash Withdrawal \n 3.Cash Deposit");

                switch (costumerChoise = Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($" Your balance is :  {foundC.Money} $");
                        Console.WriteLine("Thank you for using the ATM application");
                            break;
                    case "2":
                        Console.WriteLine("Cash Withdrawal \n ");
                        
                        int cashOut = int.Parse(Console.ReadLine());
                        int result = foundC.Money - cashOut;
                        foundC.Money = result;
                        Console.WriteLine($"You withdrew {cashOut}$. You have {result}$ left on your account");
                        Console.WriteLine("Thank you for using the ATM application");
                        break;
                    case "3":
                        Console.WriteLine("Cash Deposit");
                        int cashIn = int.Parse(Console.ReadLine());
                        int resultCashIn = cashIn + foundC.Money;
                        Console.WriteLine($"You deposit of {cashIn}$ is on your bank account.\n You have {resultCashIn}$ left on your account");
                        Console.WriteLine("Thank you for using the ATM application");
                        break;

                    default:
                        break;
                }
            

            }
                Console.WriteLine("Do you want another action  ? \n y/n");
                if (Console.ReadLine() == "y")
                {
                    newTransaction = true;
                    Console.Clear();
                }
                else
                {
                    newTransaction = false;
                    Console.WriteLine("Goodbye and thank you for using this ATM :) ");
                }


            Console.ReadLine();
            }
        }
    }
}
