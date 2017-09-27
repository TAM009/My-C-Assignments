using System;
using maincode;

namespace Loop.code
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number you want the number to loop");

            int number=int.Parse(Console.ReadLine());

            LoopedNumber L = new LoopedNumber();

            L.NewNumber(number);

        }
    }
}
