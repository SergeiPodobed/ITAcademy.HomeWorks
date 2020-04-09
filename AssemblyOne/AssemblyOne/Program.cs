using System;
using System.Reflection.Metadata;
using AssemblyTwo;


namespace AssemblyOne
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();
            User user = new User();
            motorcycle.name = "BMW";
            Console.ReadKey();
        }
    }
    
}
