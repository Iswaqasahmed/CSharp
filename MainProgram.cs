using OOP.AccessModifier;
using OOP.Constructor;
using System;
using System.Collections.Generic;
using OOP.SingleTonClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using OOP.DesignPattern.SingleTonClass;
using System.Threading;

namespace CSharp
{
    class MainProgram//:AccessDemo
    {

        
       
        static void Main(string[] args)
        {



            #region Singleton 

            //Parallel.Invoke(
            //    () => PrintInstance1(),
            //    () => PrintInstance2()
            //    );

            //SingleTon instance2 = SingleTon.GetInstance;
            //instance2.PrintDetails("Second instance... ");

            //SingleTon instance1 = SingleTon.GetInstance;
            //instance1.PrintDetails("First instance... ");


            #endregion

            #region Singleton thread safe

            // SingletonSealedUsed.DerivedClass drive = new SingletonSealedUsed.DerivedClass();
            //drive.DisplayMessage("derive class message");

            Parallel.Invoke(
                () => PrintInstanceLazy1(),
                () => PrintInstanceLazy2()
                );


            //Parallel.Invoke(
            //   () => PrintInstanceThreadSafe1(),
            //   () => PrintInstanceThreadSafe2()
            //   );

            #endregion



            #region lazy loadin vs earger loading

            //lazyVsEagerLoading lazyVsEagerLoading = lazyVsEagerLoading.GetInstance;
            #endregion



            #region AccessModifier

            //new MyDerivedClass().AccessProtectedInternalMember();
            //MainProgram mp = new MainProgram();
            //Console.WriteLine("Case-IV:  ");
            //mp.Pubic();
            //mp.Protected();
            //mp.ProtectedInternal();

            #endregion


            Console.ReadKey();
        }

        private static void PrintInstance1()
        {
            SingleTon instance1 = SingleTon.GetInstance;
            instance1.PrintDetails("First instance... ");
        }
        private static void PrintInstance2()
        {
            SingleTon instance2 = SingleTon.GetInstance;
            instance2.PrintDetails("Second instance... ");
        }


        private static void PrintInstanceThreadSafe1()
        {
            lazyVsEagerLoading instance1 = lazyVsEagerLoading.GetInstance;
            instance1.PrintDetials("First instance... ");
        }
        private static void PrintInstanceThreadSafe2()
        {
            lazyVsEagerLoading instance2 = lazyVsEagerLoading.GetInstance;
            instance2.PrintDetials("Second instance... ");
        }


        private static void PrintInstanceLazy1()
        {
            LazyClass instance1 = LazyClass.GetInstance;
            instance1.PrintDetials("Lazy Loading instance 1... ");
        }
        private static void PrintInstanceLazy2()
        {
            LazyClass instance2 = LazyClass.GetInstance;
            instance2.PrintDetials("Lazy Loading instance 2... ");
        }

    }
}
