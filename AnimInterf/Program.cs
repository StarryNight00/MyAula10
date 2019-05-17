using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Animal[] animals = new Animal[10];

            foreach (Animal i in animals)
            {
                int choice = rnd.Next(4);

                if (choice == 0) animals[i] = new Dog();
                if (choice == 1) animals[i] = new Cat();
                if (choice == 2) animals[i] = new Bat();
                if (choice == 3) animals[i] = new Bee();
            }

            foreach (Animal i in animals)
            {
                Console.WriteLine($"This animal is a {i}");
            }

        }
    }
}
