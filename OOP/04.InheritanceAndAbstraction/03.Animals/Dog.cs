namespace _03.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base (name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " said: Bark.");
        }
    }
}
