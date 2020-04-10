using System;

namespace Motorcycle
{
    public class Motorcycle
    {
        const ushort maxSpeed = 300;
        private string vinNumber = "223344-WVW-009987-FD";
        internal int odometr = 20_000;
        protected private string name;
        protected double volume;
        protected internal int age;
        public string type;

        // по умолчанию имеет модификатор private
        void defaultStartEngine() => Console.WriteLine($"vinNumber = {vinNumber}");
        // доступен в любом месте текущего проекта
        internal void internalStartEngine() => Console.WriteLine($"odometr = {odometr}");
        // доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected private void protectedprivatStartEngine() => Console.WriteLine($"name = {name}");
        // доступен из текущего класса и производных классов
        protected void protectedStartEngine() => Console.WriteLine($"volume = {volume}");
        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal void protectedinternalStartEngine() => Console.WriteLine($"age = {age}");
        // доступен в любом месте программы, а также для других программ и сборок
        public void publicStartEngine() => Console.WriteLine($"type = {type}");
    }


 }
