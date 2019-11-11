using System;

namespace Mesec.v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mesec = int.Parse(Console.ReadLine());
            if (mesec == 1)
            {
                Console.WriteLine("Januar!");
            }
            else if (mesec == 2)
            {
                Console.WriteLine("Februar!");
            }
            else if (mesec == 3)
            {
                Console.WriteLine("Mart!");
            }
            else if (mesec == 4)
            {
                Console.WriteLine("April!");
            }
            else if (mesec == 5)
            {
                Console.WriteLine("Maj!");
            }
            else if (mesec == 6)
            {
                Console.WriteLine("Jun!");
            }
            else if (mesec == 7)
            {
                Console.WriteLine("Jul!");
            }
            else if (mesec == 8)
            {
                Console.WriteLine("Avgust!");
            }
            else if (mesec == 9)
            {
                Console.WriteLine("Septembar!");
            }
            else if (mesec == 10)
            {
                Console.WriteLine("Oktobar!");
            }
            else if (mesec == 11)
            {
                Console.WriteLine("Novembar!");
            }
            else if (mesec == 12)
            {
                Console.WriteLine("Decembar!");
            }
            else
            {
                Console.WriteLine("Greska! Nepostojeci Mesec!");
            }
        }
    }
}
