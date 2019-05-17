using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar variáveis
            const int nAnimals = 10;
            Random rnd = new Random();
            Animal[] animals = new Animal[nAnimals];

            //Inicializar conteúdos array
            for (int i = 0; i < nAnimals; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        animals[i] = new Dog();
                        break;
                    case 1:
                        animals[i] = new Cat();
                        break;
                    case 2:
                        animals[i] = new Bat();
                        break;
                    case 3:
                        animals[i] = new Bee();
                        break;
                }

            }


            //Percorrer Array
            foreach (Animal a in animals)
            {
                Console.WriteLine($"\n\nThis animal is a {a}");
                string nipples = a is IMammal ? "\nNum of nipples = " + (a as IMammal).NumberOfNipples : "";
                string wings = a is ICanFly ? "\nNum of wings = " + (a as ICanFly).NumberOfWings : "";
                Console.WriteLine("It makes " + a.Sound() + nipples + wings);
            }

            Console.ReadKey();

        }
    }
}
