using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.ClassCar;



namespace Exercise01.ClassCar
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver _driver { get; set; }

        public Car(string model , int speed)
        {
            Model = model;
            Speed = speed;
        }


        public int CalculateSpeed(Driver driver)
        {
            _driver = driver;
            if (_driver != null)
            {
                int result = driver.Skill * Speed;
                return result;
            }

            return -1;
        }
    }
}

