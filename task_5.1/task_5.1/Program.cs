using System;

namespace task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Английский алфавит");
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int L = abc.Length - 1;
            var bca = abc.ToCharArray();

            for (int i = L; i >= 0; i--)

            {
                var temp = bca[i];
                bca[L - i] = temp;
            }

            Console.WriteLine("Алфавит в обратном порядке");
            Console.WriteLine(new string(bca));
        }
    }
}
