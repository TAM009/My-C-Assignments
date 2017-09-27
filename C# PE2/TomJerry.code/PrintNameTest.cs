using System;

namespace TestCode
{
    public class Codetest
    {
        public bool ToPrintTom(int num)
        {
            if((num%2!=0)&&((num>20)&&(num<30)))
            return true;

            else 
            return false;
        }

        public bool ToPrintJerry(int num)
        {
            if((num%2==0)&&((num>20)&&(num<30)))
            return true;

            else 
            return false;
        }
    }
}