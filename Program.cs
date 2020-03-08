using System;

namespace HW03.Task1
{
    class Program
    {
        
            static void Main(string[] args)
            {

                byte a = 5;                   // неявное преобразование типов прим. 1
                int b = a + 95;

                int c = 5;                      // неявное преобразование типов прим. 2
                long d = c - 1000000;

                float e = 258;                   // неявное преобразование типов прим. 3
                double f = e * (-1.3);

                int g = 10;                      // явное преобразование типов прим. 1
                int h = 20;
                ushort i = (ushort)(g + h);

                double j = 5.2877986579;         // явное преобразование типов прим. 2
                float k = (float)j;

                ulong l = 1200034000002300;      // явное преобразование типов прим. 3
                sbyte m = (sbyte)l;

                byte a1 = 24;                      // boxing 1
                object obj1 = a1;
                byte b1 = (byte)obj1;               // unboxing 1

                bool a2 = false;                   // boxing 2
                object obj2 = a2;
                bool b2 = (bool)obj2;              // unboxing 2

                double a3 = 1.325;                 // boxing 3
                object obj3 = a3;
                double b3 = (double)obj3;          //unboxing 3

                int a4 = 4;                       //boxing-unboxing int into ushort
                object obj4 = a4;
                ushort b4 = (ushort)(int) obj4;

                bool a5 = true;                   //boxing-unboxing bool into byte
                object obj5 = a5;
                byte b5 = Convert.ToByte(obj5);

                char a6 = '\x5A';                 //boxing-unboxing char into int
                object obj6 = a6;
                int b6 = Convert.ToInt32(obj6);

                                                         
                Console.WriteLine($"Неявное преобразование: {b} {d} {f}");
                Console.WriteLine($"Явное преобразование: {i} {k} {m}");
                Console.WriteLine($"Boxing-unboxing: {b1} {b2} {b3}");
                Console.WriteLine($"Boxing-unboxing int into ushort: {b4}");
                Console.WriteLine($"Boxing-unboxing bool into byte: {b5}");
                Console.WriteLine($"Boxing-unboxing bool into byte: {b6}");



        }
        }
    }
