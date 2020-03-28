using System;

namespace task_8._1
{
    class Program
    {
        private static readonly string song;

        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите с помощью клавиатуры стихотворение в одну строку" + "," + '\n' + "используя ; в качестве разделителя" + '\n');

            string text = Console.ReadLine();
            text = text.Replace("o", "a");
            string[] arr_text = text.Split(new char[] { ';' });
            
                foreach (string s in arr_text)
            {
                Console.WriteLine(s);
            }
        }
    }
}
        
    
