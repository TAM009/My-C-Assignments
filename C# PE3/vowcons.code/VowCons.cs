using System;

namespace maincode
{
    public class VowCons
    {

        public void CheckVowelOrConsonant( string word)
        {
            try
            {

                    char[] array=word.ToCharArray();

                    for(int i=0;i<array.Length;i++)
                    {
                        char letter=array[i];

                        if((array[i]>='A'&& array[i]<='Z')||(array[i]>='a'&& array[i]<='z'))
                        {

                            if(array[i]=='a'||array[i]=='e'||array[i]=='i'||array[i]=='o'||array[i]=='u'||array[i]=='A'||array[i]=='E'||array[i]=='I'||array[i]=='O'||array[i]=='U')
                            Console.Write(" {0} : vowel, ", array[i]);
                            else
                            Console.Write(" {0} : Consonant, ",array[i]);

                        }

                        else
                        Console.WriteLine(" {0} is not a letter", array[i]);
                    }

            }

            catch(Exception ex)
            {
                        Console.WriteLine(ex.Message);
            }
        }
    }
}