using System;
using maincode;

namespace sortnumberdigits.code
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number that you want to sort");

            String input=Console.ReadLine();

            sortcode sc =new sortcode();

            sc.sortnumber(input);

        }
    }
}
