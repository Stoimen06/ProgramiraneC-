using System;
using System.Linq;
using System.Collections.Generic;

namespace _14._04._dom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> producti = new List<string>();
            producti.Add("mlqko");
            producti.Add("elda");
            Console.WriteLine("Productite pyrwonachalno sa:");
            for (int i = 0; i < producti.Count; i++)
            {
                Console.WriteLine(producti[i]);
            }
            for (int i = 0; i < producti.Count; i++)
            {
                if (producti[i] == "elda")
                {
                    Console.WriteLine("Da ima elda");
                }
            }
            Console.WriteLine(producti.Contains("elda"));
            producti.Insert(2,"duner");
            Console.WriteLine("Spisyka s dobawen duner");
            for (int i = 0; i < producti.Count; i++)
            {
                Console.WriteLine(producti[i]);
            }
            Console.WriteLine("Productite w kraq sa");
            for (int i = 0; i < producti.Count; i++)
            {
                Console.WriteLine(producti[i]);
            }
        }
    }
}
