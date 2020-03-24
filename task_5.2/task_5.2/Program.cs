using System;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: цифру или букву с клавиатуры");
            string x = Console.ReadLine();
            Console.WriteLine("Введите символ W(вверх) или S(вниз) или A(вправо) или D(влево)");
            string y = Console.ReadLine();
            switch (y)
            {
                case "W":
                    Console.WriteLine($"Символ {x} перемещается вверх");
                    break;
                case "S":
                    Console.WriteLine($"Символ {x} перемещается вниз");
                    break;
                case "A":
                    Console.WriteLine($"Символ {x} перемещается вправо");
                    break;
                case "D":
                    Console.WriteLine($"Символ {x} перемещается влево");
                    break;
                default:
                    Console.WriteLine("Введена неверная команда");
                    break;

            }
            {


            }



        }
    }
}
