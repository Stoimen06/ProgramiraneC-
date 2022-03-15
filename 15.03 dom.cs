using System;

namespace _15._03_dom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vtornik");
            Console.WriteLine("Vyvedete broq na chasovete");
            int n = int.Parse(Console.ReadLine());
            string[] chasove = new string[n];
            for (int i = 0; i < chasove.Length; i++)
            {
                Console.WriteLine("Vyvedete predmet");
                chasove[i]=Console.ReadLine();
            }
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i+ " "+chasove[i]); 
            }
        }
    }
}
