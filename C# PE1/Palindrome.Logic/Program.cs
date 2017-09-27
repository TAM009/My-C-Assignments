using System;
using NumPalindrome;

namespace Palindrom.Logic
{
    class Program
    {
        public static void Main()
        {
            long number;

            Console.WriteLine("Enter the number you want to check is palindrome");

            number=long.Parse(Console.ReadLine());

            Palindrome P = new Palindrome();

            P.CheckPalindrome(number);

        }
    }
}
