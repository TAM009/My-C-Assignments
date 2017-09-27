using System;


namespace NumPalin
{

    public class SumCheckTest
    {
        
        public bool IsSumGreater(long num1)
        {
                long digit1, sum1=0;

                do{
                    digit1=num1%10;

                    if((digit1%2)==0)
                    sum1+=digit1;

                    num1=num1/10;
                }while(num1!=0);

                if(sum1>25)
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