using System;


namespace OOP.AccessModifier
{
    public class Animal
    {
        protected string sound;

        public Animal(string sound)
        {
            this.sound = sound;
        }

        protected void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }

    public class Dog : Animal
    {
        public Dog() : base("Woof!")
        {
        }

        public void Bark()
        {
            MakeSound(); // Accessible because Dog derives from Animal
        }
    }

    public class ProgramMain
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Bark(); // Outputs "Woof!"
        }
    }
}