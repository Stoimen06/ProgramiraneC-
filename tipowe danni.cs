using System;

namespace tipowe_danni
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stoinost = true;
            char bukva = 'c';
            byte chislo = 100;
            ushort chislo1 = 20000;
            ushort chislo2 = 30000;
            string pp = "programirane";
            Console.WriteLine("Promenliwa ot tip bool e: " + stoinost);
            Console.WriteLine("Promenliwa ot tip char e: " + bukva);
            Console.WriteLine("Promenliwa ot tip byte e: " + chislo);
            Console.WriteLine("Promenliwa ot tip ushort e: " + chislo1);
            Console.WriteLine("Promenliwa ot tip ushort e: " + chislo2);
            Console.WriteLine("Promenliwa ot tip string e: " + pp);
        }
    }
}
