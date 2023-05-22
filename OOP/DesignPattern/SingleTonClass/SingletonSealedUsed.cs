using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPattern.SingleTonClass
{
    public sealed class SingletonSealedUsed
    {
        private static int Count = 0;
        private static object obj = new object();
        private static SingletonSealedUsed _instance = null;
        private SingletonSealedUsed()
        {
            Count++;
            Console.WriteLine("this is base class, Count value is: " + Count);
        }
        public static SingletonSealedUsed GetInstance
        {
            get
            {
                return _instance;
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }


        // Reason why we used sealed class is, in nested class we can able to call private constructor, 
        //therefore the singleton design pattern is not fullfilled.
        
        //public class DerivedClass:SingletonSealedUsed
        //{
            
        //}





        

    }
}
