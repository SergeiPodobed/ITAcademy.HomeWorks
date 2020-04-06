using System;

namespace Task_1._1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] mas1 = new int[4];
            int[] mas2 = new int[4];
            int[] mas3 = new int[4];

            Random rnd = new Random();

            Console.WriteLine($"Элементы массива mas1");
                        
                for (int i = 0; i < 4; i++)
            {
                mas1[i] = rnd.Next(100);

                Console.WriteLine ($" {mas1[i]} ");

            }

            Console.WriteLine($"Введите 4 элемента массива mas2 от 0 до 100, подтверждая ввод клавишей Enter");
            {
                for (int i = 0; i < 4; i++)

                    mas2[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine($"Поэлементная сумма массивов mas1 и mas2");

            {

                for (int i = 0; i < 4; i++)

                    mas3[i] = mas1[i] + mas2[i];

                foreach (int i in mas3)

                    Console.WriteLine(i);
            }

            


            
        }
    }
}
