using System;
namespace OOPTekrar.AnimalsOOP
{
    public class Animal
    {
        public int Age { get; set; }

        public Animal(){}

        public void Eat()
        {
            Console.WriteLine("Yes it's time to eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Time to sleep kids");
        }

    }
}
