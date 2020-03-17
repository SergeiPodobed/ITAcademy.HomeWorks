using System;

namespace HW3.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a1 = 12;
            Int32 b1 = 12;

            byte a2 = 12;
            Byte b2 = 12;

            char a3 = '\x5A';
            Char b3 = '\x5A';

            object a4 = 12;
            System.Object b4 = 12;
           
            string a5 = "test";
            System.String b5 = "test";

           


            Console.WriteLine(a1.GetType());
            Console.WriteLine(b1.GetType());
            Console.WriteLine(a2.GetType());
            Console.WriteLine(b2.GetType());
            Console.WriteLine(a3.GetType());
            Console.WriteLine(b3.GetType());
            Console.WriteLine(a4.GetType());
            Console.WriteLine(b4.GetType());
            Console.WriteLine(a5.GetType());
            Console.WriteLine(b5.GetType());



        }
    }
}
