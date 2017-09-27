using System;
using maincode;

namespace vowcons.code
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word:");

            string word;
            
            word=Console.ReadLine();

            VowCons v = new VowCons();

            v.CheckVowelOrConsonant(word);
            
        }
    }
}
