using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeTask12
{
    public class Race
    {
        private readonly List<Car> cars = new List<Car>();
        private readonly Timer raceTimer = new Timer(1000);

        public void AddCar(Car car)
        {
            cars.Add(car);
            car.OnFinished += Car_OnFinished;
        }

        public void StartRace()
        {
            Console.WriteLine("Гонка началась!");
            raceTimer.Elapsed += OnRaceTick;
            raceTimer.Start();
        }

        private void OnRaceTick(object sender, ElapsedEventArgs e)
        {
            foreach (var car in cars)
            {
                if (car is SportsCar sportsCar)
                {
                    sportsCar.OnRaceTick();
                }
            }
        }

        private void Car_OnFinished(Car car)
        {
            raceTimer.Stop();
            raceTimer.Elapsed -= OnRaceTick;
            Console.WriteLine($"{car.Name} победил в гонке, проехав {car.Distance}!");
        }
    }
}
