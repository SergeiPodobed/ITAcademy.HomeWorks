using System;

namespace AssemblyTwo
{
        class Program    
   {
        static void Main(string[] args)
        {
            Motorcycle motorcycle3 = new Motorcycle();

            motorcycle3.maxSpeed = 200;                 // по умолчанию private, не может быть вызвана в дрг классе
            motorcycle3.vinNumber = "fff-444-555-ooo";  // private, не может быть вызвана в дрг классе
            motorcycle3.odometr = 12_000;               // internal, доступен в люб месте тек проекта
            motorcycle3.name = "BMW";                   // protected private, доступен в тек и произв классе
            motorcycle3.age = 3;                        // protected internal, доступен в люб месте тек проекта и из наследн
            motorcycle3.type = "bike";                  // public доступен в любом месте программы

            Console.ReadKey();
        }
    }
}
