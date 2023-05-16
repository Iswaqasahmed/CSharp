using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    public class AccessDemo
    { 



        #region Comment 

        //private void Demo()
        //{

        //    Console.WriteLine("this is demo of private method ");
        //}

        //private void PrivateDemo()
        //{
        //    Demo();
        //}

        //protected void PrivateDemoProtected()
        //{
        //    Console.WriteLine("Private Demo Procted method");
        //}


        //protected void PrivateDemoProtectedDisplay()
        //{
        //    PrivateDemoProtected();
        //}

        //internal void InternalDemo()
        //{
        //    Console.WriteLine("this is internal Demo method");
        //}



        //public void PublicDemo()
        //{
        //    Console.WriteLine("public demo method is called");
        //}


        #endregion


        /// <summary>
        ///  Access Modifier or Specifier
        /// </summary>


        public void Pubic()
        {
            Console.WriteLine("this is pbulic method");
        }

        internal void Internal()
        {
            Console.WriteLine("this is internal method");
        }
        internal protected void InternalProtected()
        {
            Console.WriteLine("this is internal protected method");
        }


        protected void Protected()
        {
            Console.WriteLine("this is protected method");
        }


        protected internal void ProtectedInternal()
        {
            Console.WriteLine("this is proctected internal method");
        }

        


        // case - 01
        public AccessDemo()
        {
            Console.WriteLine("Case -1: Consume members of a class in Same Class");
            Pubic();
            Internal();
            Protected();
            //Private();
            ProtectedInternal();
        }




    }
}
