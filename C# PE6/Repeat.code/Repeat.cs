using System;

namespace maincode
{
    public class RepeatCode
    {
        public void Repeat(string a, int b)
        {
            try
            {
                char[] array=a.ToCharArray();

                Console.Write(a);

                for(int i=0;i<b;i++)
                {
                    for(int j=(array.Length-b);j<array.Length;j++)
                    {
                        Console.Write(array[j]);
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

    }
}