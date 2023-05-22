using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPattern.SingleTonClass
{

    // Lazy vs Eager loading in Singleton

    public sealed class lazyVsEagerLoading
    {
        // lazy loading
        // improve the performance
        // avoding unncescessar laod till the point object is accessed.
        // readuce the meemory footprint on the start up
        //faster applciation load


        // non lzay or eager loading
        // pre instantiation of the object before object is called.
        // commonay used in lower memory footprint


        private static int counter = 0;
        private static readonly lazyVsEagerLoading _instance = new lazyVsEagerLoading();

        
        private lazyVsEagerLoading()
        {
            counter++;
            Console.WriteLine("Counter Value is " + counter);
        }


        public static lazyVsEagerLoading GetInstance
        {
            get
            {
                return _instance;
            }
        }


        public void PrintDetials(string message)
        {
            Console.WriteLine( message);
        }

        
    }


    public sealed class LazyClass
    {
        // by default lazy object are thread safe ( lazy is keyword here )
        private static int counter = 0;
        private static readonly Lazy<LazyClass> _instance = new Lazy<LazyClass>(() => new LazyClass());

        private LazyClass()
        {
            counter++;
            Console.WriteLine("Counter Value is " + counter);
        }

        public static LazyClass GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void PrintDetials(string message)
        {
            Console.WriteLine(message);
        }

    }
    
}