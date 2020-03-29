using System;
using System.IO;

namespace hw_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Каждый охотник желает знать где сидит фазан";
            Console.WriteLine($"Исходный текст \n{ text }");
            string[] words = text.Split(new char[] { ' ' });
            string max = String.Empty;
           
            for (int i = 0; i < words.Length; i++)
            {
                string longword = words[i];

                if (longword.Length > max.Length)
                {
                    max = longword;
                    text = text.Replace(max, string.Empty);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Текст без длинного слова \n{text}");


        }
    }
}


       
    

    

