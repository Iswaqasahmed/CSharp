using System;

class MyClass
{
    private int privateField;  // Private field

    private void PrivateMethod()  // Private method
    {
        Console.WriteLine("This is a private method.");
    }

    public void PublicMethod()  // Public method
    {
        Console.WriteLine("This is a public method.");

        privateField = 10;  // Accessible within the same class
        PrivateMethod();   // Accessible within the same class
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.PublicMethod();

        // The following lines would result in compilation errors:
        // myObject.privateField = 20;     // Cannot access privateField outside MyClass
        // myObject.PrivateMethod();       // Cannot access PrivateMethod outside MyClass
    }
}
