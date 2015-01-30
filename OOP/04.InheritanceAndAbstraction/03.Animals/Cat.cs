namespace _03.Animals
{
    using System;

    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, string gender) : base (name, age, gender)
        {
            
        }

        public override void ProduceSound()
        {
            Console.WriteLine(this.Name + " said: Meow.");
        }
    }
}
