using System;


namespace check_in
{
    class Program
    {
        const string Bortnumber = "LH-44556";
        const string Destination = "Larnaka";
        const int Bortcapacity = 175;
        static void Main(string[] args)
        {
            Console.WriteLine($"Dear Madame/Sir pleas input your first then last name");
            string Name = Console.ReadLine();
            Console.WriteLine($"Pleas input your pasport number");
            string Pasport = Console.ReadLine();
            Random rnd = new Random();
            int turn = rnd.Next(1, 175);
            Console.WriteLine($"Your turn is {turn}, check in started at {DateTime.Now}");
            Console.WriteLine($"If you have hand luggage push H");
            int[] rows = new int [5];

            // константы: номер рейса, направление, максимальная вместимость самолета
            // invitation, input: name, pasport; output: confirm, number in the queue, current date and time     
            // вводимые данные пишем в массив размерностью - вместимость самолета 
            // вопрос о багаже: (а) если ручная кладь, то присваевается место (2х мерный массив) и напвление на паспортный контроль
            // (б) если багаж сдается, производится контроль веса, доплата за перевес, присваевается номер багажа и в пункт (а)
            // на паспортном контроле запрашивается номер паспорта и проверяется его соответствие введенному номеру вначале  
            // если все хорошо, выводится информация: фио, добро пожаловать на борт, след по маршр в г. Ларнака, место___  

        }
    }



}
