using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
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

        void defaultStartEngine() => Console.WriteLine($"vinNumber = {vinNumber}");
        // по умолчанию имеет модификатор private
        internal void internalStartEngine() => Console.WriteLine($"odometr = {odometr}");
        // доступен в любом месте текущего проекта
        protected private void protectedprivatStartEngine() => Console.WriteLine($"name = {name}");
        // доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected void protectedStartEngine() => Console.WriteLine($"volume = {volume}");
        // доступен из текущего класса и производных классов
        protected internal void protectedinternalStartEngine() => Console.WriteLine($"age = {age}");
        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        public void publicStartEngine() => Console.WriteLine($"type = {type}");
        // доступен в любом месте программы, а также для других программ и сборок

    }
}
