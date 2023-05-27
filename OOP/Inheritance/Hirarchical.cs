using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Hirarchical
    {
        public Hirarchical()
        {
            A a = new B();
            B b = new B();

            A a1 = b;
            C c = new C();
            A a2 = new C();

            A a3 = c;


            B b4 = new C();
            B b5 = c;

            //C c4 = new A();

        }
    }
    public class A { }
    public class B : A { }
    public class C : B { }
}
