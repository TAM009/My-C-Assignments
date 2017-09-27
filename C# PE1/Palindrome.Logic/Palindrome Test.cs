using System;

namespace NumPalin
{
    public class PalindromeTest
    {
        public bool IsAPalindrome(long num)
        {
                long temp = num;
                long rem, rev = 0;
                while (num > 0)
                {
                    rem = num % 10;
                    rev = rev * 10 + rem;
                    num /= 10;
                }
                if(temp==rev)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}