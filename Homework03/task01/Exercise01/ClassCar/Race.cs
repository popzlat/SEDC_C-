using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.ClassCar
{
   public class Race
    {

        
        public string RaceCars(Car car1, Car car2 ,Driver driver1 , Driver driver2 )
        {
            int result1 = car1.CalculateSpeed(driver1);
            int result2 = car2.CalculateSpeed(driver2);

            if (result1 >= result2)
            {
                return car1.Model;
            }
            else
            {
                return car2.Model;
            }
        }
        

    }
}
