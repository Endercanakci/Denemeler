using System;
using System.Linq;

namespace Deneme5
{
    class Program
    {
        static void Main(string[] args)
        {
            Add1();           

            var result1 = Add2();
            Console.WriteLine(result1);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1,number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            Console.WriteLine(MultiPly(2,4));
            Console.WriteLine(MultiPly(2,4,6));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            
            Console.ReadLine();
        }

        static void Add1()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            //number2 = 200;  number2 için ref kullanmadık.
            return number1 + number2;
        }

        //ref kodunu kullanmak için bir değer atanması gereklidir ama 
        //out kodunu kullanırken değer atamaya gerek yoktur.

        static double MultiPly(double number1, double number2)
        {
            return number1 * number2;
        }

        static double MultiPly(double number1,double number2,double number3)
        {
            return number1 * number2 * number3;
        }
        
        static int Add4(params int[] numbers1)
        {
            return numbers1.Sum();
        }

        
        
        
            
    }
}
