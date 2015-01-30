using System;

namespace _03.Animals
{
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Tomcat cat = new Tomcat("jonny", 4);
            Kitten cat2 = new Kitten("Holly", 2);
            Frog frog = new Frog("Jwey", 6, "male");
            Dog dog = new Dog("Sharo", 3, "male");
            cat.ProduceSound();
            cat2.ProduceSound();
            frog.ProduceSound();
            dog.ProduceSound();

            Animal[] animals = {
                cat, 
                cat2, 
                frog, 
                dog,
                new Dog("Polly", 12, "female"),
                new Frog("Kolio", 2, "male"),
                new Tomcat("Nuni", 3),
                new Kitten("Loly", 9),
                new Frog("Josh", 1, "male"),
                new Kitten("Jenny", 5),
                new Dog("Bond", 5, "male"),
                new Tomcat("Josh", 14)
            };

            var dogs = from animal in animals
                where animal is Dog
                select animal;

            var frogs = from animal in animals
                where animal is Frog
                select animal;

            var cats = from animal in animals
                where animal is Cat
                select animal;

            Console.WriteLine("Dogs avg age: " + ((double)dogs.Sum(a => a.Age)) / dogs.Count());

            Console.WriteLine("Frogs avg age: " + ((double)frogs.Sum(a => a.Age)) / frogs.Count());

            Console.WriteLine("Cats avg age: " + ((double)cats.Sum(a => a.Age)) / cats.Count());
        }
    }
}
