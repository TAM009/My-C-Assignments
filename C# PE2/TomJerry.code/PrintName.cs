using System;


namespace MainCode{

    public class Print
    {
        public void PrintName(int number)
        {
            try
            {
                int temp;

                temp=number;

                if((number%2!=0)&&(number>20&&number<30))
                {
                    Console.WriteLine("Tom");
                }

                else if((number%2==0)&&((number>20)&&(number<30)))
                {
                    Console.WriteLine("Jerry");
                }

            }
           
           
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}