using System;

namespace maincode
{
    public class LoopedNumber
    {
        public void NewNumber(int n)
        {
            try
            {
                for(int i=1;i<=n;i++)
                {
                    for(int j=0;j<i;j++)
                    Console.Write( "{0} ",i);
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}