﻿using System;


namespace check_in
{
    class Program
    {
        const string Bortnumber = "LH-44556";
        const string Destination = "Larnaka";
        const int Bortcapacity = 175;
        const int extrapay = 9;
        const int weight = 23;
        static void Main(string[] args)
        {
            Console.WriteLine($"Dear Madame/Sir pleas input your name");
            Console.WriteLine($"Pleas input your's pasport number");
            Random rnd = new Random();
            int turn = rnd.Next(1, 35);
            Console.WriteLine($"Your turn is {turn}, check in started at {DateTime.Now}");
            Console.WriteLine($"Push H in case hand luggage, push C - in case to check in your luggage");
            string luggage = Console.ReadLine();
            switch (luggage)
            {
                case "H":
                    Console.WriteLine($"Pleas reserve a sit");
                    Console.WriteLine($"To reserve a sit choose a row A, B, C, D or E");
                    string row1 = Console.ReadLine();
                    if (row1 == "A")
                        Console.WriteLine($"Your sit is {"A"}{turn}, {Bortnumber}, destination {Destination}");
                        Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    if (row1 == "B")
                        Console.WriteLine($"Your sit is {"B"}{turn}, {Bortnumber}, destination {Destination}");
                        Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    if (row1 == "C")
                        Console.WriteLine($"Your sit is {"C"}{turn}, {Bortnumber}, destination {Destination}");
                        Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    if (row1 == "D")
                        Console.WriteLine($"Your sit is {"D"}{turn}, {Bortnumber}, destination {Destination}");
                        Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    if (row1 == "E")
                        Console.WriteLine($"Your sit is {"E"}{turn}, {Bortnumber}, destination {Destination}");
                        Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    break;
                
                case "C":
                    Console.WriteLine($"Pleas put yours luggage on weight");
                    Random rnd1 = new Random();
                    int weight1 = (rnd1.Next(5, 40));
                    int pay = (weight1 - weight) * extrapay;
                    Console.WriteLine($"Weight of luggage is {weight1}");
                    if (pay > 0)
                    {
                        Console.WriteLine($"Pleas pay {pay * extrapay} eur");
                        Console.WriteLine($"Pleas enter sum for payment");
                        int sum = Convert.ToInt32(Console.ReadLine());
                        if (sum == pay * extrapay)
                        {
                            Console.WriteLine($"Pleas reserve a sit");
                            Console.WriteLine($"To reserve a sit choose a row A, B, C, D or E");
                            string row2 = Console.ReadLine();
                            if (row2 == "A")
                                Console.WriteLine($"Your sit is {"A"}{turn}, {Bortnumber}, destination {Destination}");
                                Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                            if (row2 == "B")
                                Console.WriteLine($"Your sit is {"B"}{turn}, {Bortnumber}, destination {Destination}");
                                Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                            if (row2 == "C")
                                Console.WriteLine($"Your sit is {"C"}{turn}, {Bortnumber}, destination {Destination}");
                                Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                            if (row2 == "D")
                                Console.WriteLine($"Your sit is {"D"}{turn}, {Bortnumber}, destination {Destination}");
                            if (row2 == "E")
                                Console.WriteLine($"Your sit is {"E"}{turn}, {Bortnumber}, destination {Destination}");
                                Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                        }
                        else
                        {
                            Console.WriteLine($"You entered incorrect sum");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"To reserve a sit choose a row A, B, C, D or E");
                        string row2 = Console.ReadLine();
                        if (row2 == "A")
                            Console.WriteLine($"Your sit is {"A"}{turn}, {Bortnumber}, destination {Destination}");
                            Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                        if (row2 == "B")
                            Console.WriteLine($"Your sit is {"B"}{turn}, {Bortnumber}, destination {Destination}");
                            Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                        if (row2 == "C")
                            Console.WriteLine($"Your sit is {"C"}{turn}, {Bortnumber}, destination {Destination}");
                            Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                        if (row2 == "D")
                            Console.WriteLine($"Your sit is {"D"}{turn}, {Bortnumber}, destination {Destination}");
                            Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                        if (row2 == "E")
                            Console.WriteLine($"Your sit is {"E"}{turn}, {Bortnumber}, destination {Destination}");
                            Console.WriteLine($"You are welcome on plane {Bortnumber}, destination {Destination}, have a good flight");
                    }
                    break;
                default:
                    Console.WriteLine($"Pleas do reservation one more time");
                    break;
            }
        }
    }
}

// константы: номер рейса, направление, максимальная вместимость самолета
// invitation, input: name, pasport; output: confirm, number in the queue, current date and time     
// вводимые данные пишем в массив размерностью - вместимость самолета 
// вопрос о багаже: (а) если ручная кладь, то присваевается место (2х мерный массив) и напвление на паспортный контроль
// (б) если багаж сдается, производится контроль веса, доплата за перевес, присваевается номер багажа и в пункт (а)
// если все хорошо, выводится информация: фио, добро пожаловать на борт, след по маршр в г. Ларнака, место___  


