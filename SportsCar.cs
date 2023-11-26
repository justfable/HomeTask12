using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    public class SportsCar : Car
    {
        private static readonly Random Random = new Random();

        public SportsCar(string name) : base(name, Random.Next(20, 30))
        {
        }

        public void OnRaceTick()
        {
            UpdateSpeed(); // Обновляем скорость перед каждым "тиком"
            Drive(); // Затем "едем" с новой скоростью
        }

        protected override void UpdateSpeed()
        {
            // Спортивные автомобили могут менять скорость очень быстро.
            Speed = Random.Next(20, 30); 
        }
    }
}
