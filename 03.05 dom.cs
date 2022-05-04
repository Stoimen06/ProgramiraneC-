using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._05_dom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имена и височина (в м) на ученици:");
            Dictionary<string, double> visochina = new Dictionary<string, double>();
            visochina.Add("Mladen", 1.68);
            visochina.Add("Ibraim", 1.76);
            foreach (var i in visochina)
            {

                Console.WriteLine(i + " м.");
            }
            double avg = visochina.Values.Average();
            Console.WriteLine("Средната височина е: " + avg + " м.");
        }
    }
}
