using System;

namespace Task_6._2
{
    class Program
    {
        private static readonly int x;

        static void Main(string[] args)
        {

            int[] mas1 = new int[8];
            int size = mas1.Length - 1;
            int x;                 // 8-й элемент массива                     
            byte y;                // место 8-го элемента в массиве

            Console.WriteLine($"Введите 7 элементов 8-ми значного массива mas1 от 0 до 100, подтверждая ввод клавишей Enter");

                    for (int i = 0; i < 7; i++)
                {
                     mas1[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine($"Введите 8-й элемент массива mas1 от 0 до 100, подтвердите ввод клавишей Enter");
                     x = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"Введите место 8-го элемента в массиве mas1 от 0 до 7, подтвердите ввод клавишей Enter");
                     y = byte.Parse(Console.ReadLine());

                for (int i = size - 1; y <=i; i -= 1)
                {
                      mas1[i + 1] = mas1[i];
                }
                      mas1[y] = x;
             
            Console.WriteLine($"Восьмизначный массив после добаления элемента");

                for (int i = 0; i < mas1.Length; i +=1)
            {
                Console.WriteLine(mas1[i]);
            }
        }
    }
}
