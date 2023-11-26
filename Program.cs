using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();

            race.AddCar(new SportsCar("Авто 1"));
            race.AddCar(new SportsCar("Авто 2"));
            race.AddCar(new SportsCar("Авто 3"));
            race.AddCar(new SportsCar("Авто 4"));
            race.AddCar(new SportsCar("Авто 5"));

            race.StartRace();

            Console.ReadLine(); // Держим консоль открытой, пока не будет нажата клавиша.
        }
    }
}
