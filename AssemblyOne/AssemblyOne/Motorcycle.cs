﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace AssemblyOne
{
        public class Motorcycle
    {
        public string name;
        public double volume;
        public int age;

        public void Display()
        {
            Console.WriteLine($"{name}");
        }

    }
}