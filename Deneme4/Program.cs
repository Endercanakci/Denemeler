using System;

namespace Deneme4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while (sayi <= 100)
            {
                if (sayi % 2 == 1)
                    toplam += sayi;
                sayi++;
            }
            Console.WriteLine("tek sayıların toplamı" + " : " + toplam);
            Console.ReadKey();
        }
    }
}
