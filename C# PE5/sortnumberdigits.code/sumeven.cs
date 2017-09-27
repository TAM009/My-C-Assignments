using System;

namespace maincode2
{
    public class Sum
    {
        public void Sumeven(long arr)
        {
            try
            {
                long rem,sum1=0;

                while(arr!=0)
                {
                    rem=arr%10;
                    
                    if(rem%2==0)
                    sum1+=rem;

                    arr/=10;
                }

                Console.WriteLine("Sum of the even numbers is {0}", sum1);

                if(sum1>15)
                    Console.WriteLine("True");

                else
                {
                    Console.WriteLine("False");
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}