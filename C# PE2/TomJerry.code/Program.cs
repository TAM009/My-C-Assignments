using System;
using MainCode;

namespace TomJerry.code
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");

            int input=int.Parse(Console.ReadLine());

            Print P= new Print();

            P.PrintName(input);
        }
    }
}
