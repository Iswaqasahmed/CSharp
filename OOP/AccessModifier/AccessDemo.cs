using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    public class AccessDemo
    {


        private void Demo()
        {

            Console.WriteLine("this is demo of private method ");
        }

        private void PrivateDemo()
        {
            Demo();
        }

        protected void PrivateDemoProtected()
        {
            Console.WriteLine("Private Demo Procted method");
        }


        protected void PrivateDemoProtectedDisplay()
        {
            PrivateDemoProtected();
        }

        internal void InternalDemo()
        {
            Console.WriteLine("this is internal Demo method");
        }



        public void PublicDemo()
        {
            Console.WriteLine("public demo method is called");
        }


    }
}
