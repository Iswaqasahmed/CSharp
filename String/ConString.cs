using System;

namespace CSharp.String
{
    public class ConString // string concept
    {


        public void DisplayString()
        {
            string str1 = "new string1";
            string str2 = "new string2";
            str1 += str1 + " ";
            Console.WriteLine(str1, str2);
        }


    }
}
