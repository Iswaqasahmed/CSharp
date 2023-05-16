using System;


namespace OOP.AccessModifier
{

    public class MyClass
    {
        public int MyPublicField; // Public field

        public MyClass() // Public constructor
        {
            MyPublicField = 0;
        }

        public void MyPublicMethod() // Public method
        {
            Console.WriteLine("This is a public method.");
        }

        public int MyPublicProperty { get; set; } // Public property
    }

    public class AnotherClass : MyClass
    {
        public void AnotherMethod()
        {
            MyPublicField = 10; // Accessing public field from the base class
            MyPublicMethod(); // Calling public method from the base class
            MyPublicProperty = 20; // Accessing public property from the base class
        }
    }

    public class Program
    {
        public static void Main()
        {
            MyClass myObject = new MyClass();
            myObject.MyPublicMethod(); // Accessing public method
            myObject.MyPublicProperty = 5; // Accessing public property
            Console.WriteLine(myObject.MyPublicField); // Accessing public field

            AnotherClass anotherObject = new AnotherClass();
            anotherObject.AnotherMethod();
        }
    }

}