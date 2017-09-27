using System;

namespace Testcode
{
    public class VowConsTest
    {
        bool result;

        public bool IfNotLetter(char p)
        {

            if((p>='A'&& p<='Z')||(p>='a'&& p<='z'))
            return false;

            else
            return true;
        }

        public bool IfVowel(char p)
        {
             if(p=='a'||p=='e'||p=='i'||p=='o'||p=='u'||p=='A'||p=='E'||p=='I'||p=='O'||p=='U')
             return true;

             else
             return false;
        }

        public bool IfConsonant(char p)

        {

            if((p>='A'&& p<='Z')||(p>='a'&& p<='z'))
            {
                if(p!='a'||p!='e'||p!='i'||p!='o'||p!='u'||p!='A'||p!='E'||p!='I'||p!='O'||p!='U')
                result=true;

                else
                result=false;

            }

            return result;

            
        }

        
    }
}