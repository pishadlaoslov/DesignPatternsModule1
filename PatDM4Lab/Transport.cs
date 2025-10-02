using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM4Lab
{
    public class Car : ITransport
    {
        private string _model;
        private int _speed;

        public Car(string model, int speed)
        {
            _model = model;
            _speed = speed;
        }

        public void Move() => Console.WriteLine($"Car {_model} is moving at {_speed} km/h.");
        public void FuelUp() => Console.WriteLine($"Car {_model} is fueling up with gasoline.");
    }

    public class Motorcycle : ITransport
    {
        private string _model;
        private int _speed;

        public Motorcycle(string model, int speed)
        {
            _model = model;
            _speed = speed;
        }

        public void Move() => Console.WriteLine($"Motorcycle {_model} is riding at {_speed} km/h.");
        public void FuelUp() => Console.WriteLine($"Motorcycle {_model} is fueling up with petrol.");
    }

    public class Plane : ITransport
    {
        private string _model;
        private int _speed;

        public Plane(string model, int speed)
        {
            _model = model;
            _speed = speed;
        }

        public void Move() => Console.WriteLine($"Plane {_model} is flying at {_speed} km/h.");
        public void FuelUp() => Console.WriteLine($"Plane {_model} is fueling up with aviation fuel.");
    }

    public class Bicycle : ITransport
    {
        private string _model;
        private int _speed;

        public Bicycle(string model, int speed)
        {
            _model = model;
            _speed = speed;
        }

        public void Move() => Console.WriteLine($"Bicycle {_model} is moving at {_speed} km/h.");
        public void FuelUp() => Console.WriteLine($"Bicycle {_model} doesn't need fuel.");
    }

}
