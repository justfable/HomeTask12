using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{

    public abstract class Car

    {
        protected static readonly Random Random = new Random();

        public string Name { get; private set; }
        public int Speed { get; protected set; }
        public int Distance { get; private set; }
        public event Action<Car> OnFinished;

        protected Car(string name, int initialSpeed)
        {
            Name = name;
            Speed = initialSpeed;
        }

        public void Drive()
        {
            Distance += Speed;
            Console.WriteLine($"{Name} на расстоянии {Distance}.");
            if (Distance >= 100)
            {
                OnFinished?.Invoke(this);
            }
        }

        protected virtual void UpdateSpeed()
        {
            Speed = Random.Next(20, 30);
        }
    }
}
