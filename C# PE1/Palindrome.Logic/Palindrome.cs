using System;
using CheckSum;

namespace NumPalindrome
{
    public class Palindrome
    {
        public void CheckPalindrome(long num)
        {
            try
            {
                SumCheck cs = new SumCheck();
                long temp = num;
                long digit, reverse = 0;
                while(num > 0)
                {
                    digit = num % 10;
                    reverse = reverse*10 + digit;
                    num /= 10;
                }
                if(temp == reverse)
                {
                    Console.WriteLine("Yes, The number is Palindrome!");
                    cs.sumtest(temp);
                }
                else
                {
                    Console.WriteLine("No, The number is not Palindrome!");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }  
}