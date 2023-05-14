using OOP.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AccessModifier
{
    class ChildClass
    {


        public void AccessTheAccessModifier()
        {
            AccessDemo ad = new AccessDemo();
            Console.WriteLine("Case - III: Consuming members of a class from non child class.");
            ad.Pubic();
            ad.Internal();
            ad.ProtectedInternal();



        }


    }


    class ChildClass2 : AccessDemo
    {
        public void AccessTheAccessModifier()
        {
            ChildClass2 c2 = new ChildClass2();
            Console.WriteLine("Case - II: Consuming members of a class from child class.");
            c2.Pubic();
            c2.Internal();
            c2.ProtectedInternal();
            c2.Protected();
            c2.MemberwiseClone();
        }
    }



}
