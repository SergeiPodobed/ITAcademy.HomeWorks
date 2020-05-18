using System;

namespace AssemblyOne
{
    class Program
    {
            static void Main(string[] args)
        {
            Motorcycle motorcycle1 = new Motorcycle();
           
            motorcycle1.maxSpeed = 200;                 // по умолчанию private, не может быть вызвана в дрг классе
            motorcycle1.vinNumber = "fff-444-555-ooo";  // private, не может быть вызвана в дрг классе
            motorcycle1.odometr = 12_000;               // internal, доступен в люб месте тек проекта
            motorcycle1.name = "BMW";                   // protected private, доступен в тек и произв классе
            motorcycle1.age = 3;                        // protected internal, доступен в люб месте тек проекта и из наследн
            motorcycle1.type = "bike";                  // public доступен в любом месте программы

            Console.ReadKey();
        }
        
        
    }
}
