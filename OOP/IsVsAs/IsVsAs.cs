using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.IsVsAs
{
    public class IsVsAs
    {
        // is vs as with example
        // is is used to check the type of object
        // as is used to cast the object to a type or a class


        public void AsExample()
        {
            object obj =  "abc";

            if (obj is string)
            {
                string str = obj as string;
                Nullable<int> intCheckd = obj as Nullable<int>;
                int? intCheckd2 = obj as int?;
                Console.WriteLine(str,intCheckd,intCheckd2);
            }
            else
            {
                Console.WriteLine(  "not string");
            }
        }
        
        public void IsExample()
        {
            string str = "is string";
            Console.WriteLine(str is string);
        }
    }
}
