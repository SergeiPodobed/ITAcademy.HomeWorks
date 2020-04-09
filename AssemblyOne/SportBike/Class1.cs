using System;

namespace SportBike
{
    public class SportBike : Motorcycle
    {
        public string name;
        public double volume;
        public int age;

        public void Display()
        {
            Console.WriteLine($"{name}");
        }
    }
}