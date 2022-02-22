using System;

namespace _22._02_dom
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = "12F";
            int dec = Convert.ToInt32(hex, 16);
            int dec1 = 12;
            int suma = dec + dec1;
            string suma2 = Convert.ToString(suma, 16).ToUpper();
            Console.WriteLine(dec + "(16)+ " + dec1 + "(10)" + " = " + suma2);

            string hex1 = "12F";
            int dec3 = Convert.ToInt32(hex1, 16);
            int dec4 = 12;
            int suma5 = dec3 - dec4;
            Console.WriteLine(dec3 + "(16)- " + dec4 + "(10)" + " = " + +suma5);
        }
    }
}
