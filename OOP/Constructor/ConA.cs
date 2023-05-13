using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    class ConA
    {
        // constructor ?
        //public ConA()
        //{

        //}

        static ConA()
        {
            Console.WriteLine("it is static constructor... ");
        }


        
    }

       
    class ConB : ConA
    {
        public ConB()
        {

        }



    }
    


}
