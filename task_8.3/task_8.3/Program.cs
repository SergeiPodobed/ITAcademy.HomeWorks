using System;
using System.Text;

namespace task_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$ Исходные данные: 1a!2.3!!..4.!.? 6 7!.. ?");
            string text = "1a!2.3!!..4.!.? 6 7!.. ?";
            int i1 = text.IndexOf("?");
            int i2 = text.IndexOf("!");
            int i3 = text.IndexOf(".");

            for (int i = 0; i < text.Length - 1; i++)
            {
                while (i < i1)
                {
                    string temp1 = text.Remove(i2);
                    string text_2 = temp1.Remove(i3);
                }
                Console.WriteLine(text_2);
            }

        }
               
    }
}
  
