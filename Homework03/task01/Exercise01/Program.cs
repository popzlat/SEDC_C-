using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.ClassCar;

namespace Exercise01
{

   
    class Program
    {
        

        static void Main(string[] args)
        {

            Driver hamilton = new Driver("Lewis Hamilton", 3);
            Driver verstappen = new Driver("Max Verstappen", 2);
            Driver raikonen = new Driver("Kimi Räikkönen", 1);
            Driver schumacher = new Driver("Michael Schumacher ", 3);

            Car ferrari = new Car("Ferrari",300);
            Car hyundai = new Car("Hyundai",190);
            Car mazda = new Car("Mazda",230);
            Car porsche = new Car("Porsche", 280);

            Driver[] driverArray = { hamilton, verstappen, raikonen, schumacher };
            Car[] carArray = {ferrari,hyundai,mazda,porsche};


            Console.WriteLine("Select first driver :");
            Console.WriteLine($"1){hamilton.Name} \n2){verstappen.Name}\n3){raikonen.Name}\n4){schumacher.Name}");
            int firstDriver = int.Parse(Console.ReadLine());

            Console.WriteLine("Select first car :");
            
            Console.WriteLine($"1){ferrari.Model} \n2){hyundai.Model}\n3){mazda.Model}\n4){porsche.Model}");
            int firstCar = int.Parse(Console.ReadLine());
            Driver choosenDriverOne = driverArray[firstDriver - 1];
            Car choosenCarOne = carArray[firstCar - 1];

            Console.WriteLine("Select second driver :");
            Console.WriteLine($"1){hamilton.Name} \n2){verstappen.Name}\n3){raikonen.Name}\n4){schumacher.Name}");

            int secondtDriver = int.Parse(Console.ReadLine());


            Console.WriteLine("Select first car :");
            Console.WriteLine($"1){ferrari.Model} \n2){hyundai.Model}\n3){mazda.Model}\n4){porsche.Model}");
            int secondCar = int.Parse(Console.ReadLine());

            Driver choosenDriverTwo = driverArray[firstDriver - 1];
            Car choosenCarTwo = carArray[firstCar - 1];

            Race _race = new Race();

            Console.WriteLine("Faster car was " + _race.RaceCars(choosenCarOne, choosenCarTwo, choosenDriverOne, choosenDriverTwo));


            Console.ReadLine();


        }
    }
}
