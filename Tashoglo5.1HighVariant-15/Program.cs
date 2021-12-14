using System;

namespace Tashoglo5._1HighVariant_15
{
    class Program
    {
        static void Main()
        {
            Reverse(1234);
            Console.ReadKey();
        }
        static void Reverse(int number)
        {
            int newNum = number % 10;
            Console.Write(newNum);
            number /= 10;
            if (number > 0)
                Reverse(number);
        }
    }
}
