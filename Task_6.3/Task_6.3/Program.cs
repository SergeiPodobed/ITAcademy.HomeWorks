using System;

namespace Task_6._3
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] mas1 = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int size = mas1.Length - 1;

            Console.WriteLine("\nВывод массива по порядку:");

            for (int i = 0; i <= size; i++)

            {
                Console.WriteLine(mas1[i]);

            }

            Console.WriteLine("\nВывод массива в обратном порядке:");

            for (int i = size; i >= 0; i--)

            {
                Console.WriteLine(mas1[i]);

            }



        }
        }
    }

