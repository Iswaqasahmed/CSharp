using OOP.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MainProgram:AccessDemo
    {


       
        static void Main(string[] args)
        {


            MainProgram mp = new MainProgram();
            Console.WriteLine("Case-IV:  ");
            mp.Pubic();
            mp.Protected();
            mp.ProtectedInternal();
            

        }
    }
}
