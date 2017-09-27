using System;
using maincode;

namespace Repeat.code
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string of your choice:");

            string input = Console.ReadLine();  

            Console.WriteLine("Enter the number of letters from end you would like to repeat input number of times:");

            int rep=int.Parse(Console.ReadLine());

            RepeatCode R = new RepeatCode();

            R.Repeat(input,rep);

        }
    }
}
