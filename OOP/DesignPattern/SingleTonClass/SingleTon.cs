using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SingleTonClass
{
    public sealed class SingleTon
    {

        // singleTon is creational design pattern
        private static object obj = new object();
        private static SingleTon _instance = null;
        private static int Counter = 0;

        public static SingleTon GetInstance
        {

            get
            {
                if (_instance == null) // not required call every time lock < double check locking                                                                                 principle >
                {
                    lock (obj) // only one thread enter the process other one will be lock  ( safe thread )
                    {

                        if (_instance == null)
                            _instance = new SingleTon();
                    }
                }
                
                
                return _instance;

            }
        }
        private SingleTon()
        {
            Counter++;
            Console.WriteLine("Counter value is " + Counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }




    }
}
