using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace AssemblyOne
{
    class Motorcycle
    {
        
        public const string vinNumber = "2C77799-7865-DSR-986";
        public int movetime = 300;
        public int power = 105;
        public int odometr = 12_000;

        public Motorcycle()
        {
        }

        public void StartEngine()
        {
        }

    class SportMotoCycle : Motorcycle
    {
            static void Main()
                {
                var middlespeed = new midlespeed();
                var middlepower = new middlepower();
                
                middlespeed.odometr = 220;
                middlepower.power = 300;
                
                }

    }


    }
}
