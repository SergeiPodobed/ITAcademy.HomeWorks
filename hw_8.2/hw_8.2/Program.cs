﻿using System;
using System.IO;
using System.Linq;

namespace hw_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Каждый охотник желает знать где сидит фазан ?!";
            Console.WriteLine($"Исходный текст \n{ text }");
            string[] words = text.Split(new char[] { ' ' });  
            string[] words2 = text.Split(new char[] { ' ' });
            string[] words3 = text.Split(new char[] { ' ' });
            string text_1 = text;
            string text_2 = text;
            string text_3 = text;
            string text_4 = text;
            string temp = "temp";
            string text_5 = text;
            string text_6 = text;
            int a = 0;
            var b = 0;
            
            string max = String.Empty;
            string min = "000000000000";

            for (int i = 0; i < words.Length; i++) // поиск длинного слова с последующим удалением из текста
            {
               string longword = words[i];
               
                if (longword.Length > max.Length)
               {
                    max = longword;
               }
                text_1 = text.Replace(max, " ");
               }
            Console.WriteLine();
            Console.WriteLine($"Длинное слово \n{max}");
            Console.WriteLine();
            Console.WriteLine($"Текст без длинного слова \n{text_1}");

            
            for (int i = 0; i < words2.Length; i++) // поиск короткого слова с последующей заменой короткого на длинное
            {
                string shortword = words2[i];
          
                if (shortword.Length < min.Length)
                {
                    min = shortword;
                }
                text_2 = text.Replace(max, temp);
                text_3 = text_2.Replace(min, max);
                text_4 = text_3.Replace(temp, min);
            }
            Console.WriteLine();
            Console.WriteLine($"Короткое слово \n{min}");
            Console.WriteLine();
            Console.WriteLine(($"Текст с заменой длинного слова на короткое \n{text_4}"));

            for (int i = 0; i < text_5.Length; i++) // вычисление количества букв и знаков препинания
            {
                if ((text_5[i] >= 'а' && text_5[i] <= 'я') || (text_5[i] >= 'А' || text_5[i] <= 'Я'))
                    a++;
            }

            foreach (var c in text_5) if (c == ',' || c == ';' || c == '!' || c == '?') ++b;

                Console.WriteLine();
                Console.WriteLine($"Количество букв равно {a}");
                Console.WriteLine();
                Console.WriteLine("Кол-во знаков препинания : {0}", b);

                Console.WriteLine();
                Console.WriteLine("Текст отсортированный по длине слов");

            Array.ForEach(words3.OrderByDescending(x => x.Length).ToArray(), x => Console.WriteLine(x)); // сортировка текста от длинного слова к короткому


        }
    }
}


       
    

    

