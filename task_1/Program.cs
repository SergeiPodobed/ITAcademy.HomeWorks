using System;

namespace task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] mas1 = new int[4];
            int[] mas2 = new int[4];
            int[] mas3 = new int[4];
            Random rnd = new Random();

            for (int i=0; i<3; i++)
            {
                mas1[i] = rnd.Next(3);
                Console.WriteLine($"{i}");
            }
            
                     
          
        }
    }
}
