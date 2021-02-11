using System;

namespace Deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun;
            Console.WriteLine("Günlerden birtanesini giriniz:(1-7)");
            gun = int.Parse(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Preşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumaertesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("(1-7) arasında bir sayı giriniz");
                    break;
            }
        }
    }
}