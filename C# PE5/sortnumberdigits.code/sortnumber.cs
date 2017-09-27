using System;
using maincode2;

namespace maincode
{

    public class sortcode
    {
        public void sortnumber(string num)
        {
            try
            {
                long c=long.Parse(num);

                long sum=0;

                string b=num;

                char[] array=b.ToCharArray();

                Array.Sort(array);

                Array.Reverse(array);

                string s=new string(array);

                sum=long.Parse(s);

                Console.WriteLine("The sorted number in decreasing order is {0}", sum);

                Sum d = new Sum();

                d.Sumeven(sum);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}