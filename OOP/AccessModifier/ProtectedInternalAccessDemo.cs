using System;

namespace OOP.AccessModifier
{
    // Base class
    public class MyBaseClass
    {
        protected internal int protectedInternalField = 42;

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }
    }

    // Derived class in the same assembly
    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedInternalMember()
        {
            Console.WriteLine("Accessing protected internal member from the derived class.");
            Console.WriteLine($"The protected internal field value is: {protectedInternalField}");
            ProtectedInternalMethod();
        }

        
    }
}


namespace ExampleNamespace
{
    // Another class outside the assembly
    public class AnotherClass
    {
        public void AccessProtectedInternalMember()
        {
            var instance = new OOP.AccessModifier.MyBaseClass();
            Console.WriteLine("Accessing protected internal member from another class outside the assembly.");
            Console.WriteLine($"The protected internal field value is: {instance.protectedInternalField}");
            instance.ProtectedInternalMethod();
        }
    }

    // Entry point of the program
    public class Program
    {
        public static void Main(string[] args)
        {
            var derivedInstance = new OOP.AccessModifier.MyDerivedClass();
            derivedInstance.AccessProtectedInternalMember();

            var anotherInstance = new AnotherClass();
            anotherInstance.AccessProtectedInternalMember();


         

        }
    }
}