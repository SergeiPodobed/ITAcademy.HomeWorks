using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle2 = new Motorcycle();

            motorcycle2.maxSpeed = 200;                 // по умолчанию private, не может быть вызвана в дрг классе
            motorcycle2.vinNumber = "fff-444-555-ooo";  // private, не может быть вызвана в дрг классе
            motorcycle2.odometr = 12_000;               // internal, доступен в люб месте тек проекта
            motorcycle2.name = "BMW";                   // protected private, доступен в тек и произв классе
            motorcycle2.age = 3;                        // protected internal, доступен в люб месте тек проекта и из наследн
            motorcycle2.type = "bike";                  // public доступен в любом месте программы

            Console.ReadKey();
        }


    }
}
