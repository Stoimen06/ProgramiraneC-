using System;

namespace _17._02_dom
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "1500";
            int dec = Convert.ToInt32(hex, 16);
            string hex1 = "AF";
            int dec1 = Convert.ToInt32(hex1, 16);
            int suma = dec + dec1;
            string suma2 = Convert.ToString(suma, 16).ToUpper();
            Console.WriteLine(hex+ "(16) + " + hex1 + "(16)" + "=" + suma2);
            Console.WriteLine(hex+ "(16) + " + hex1 + "(16)" + "=" + suma);
        }
    }
}
