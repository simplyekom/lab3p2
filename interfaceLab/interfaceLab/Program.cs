using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog name");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter dog colour");
            string dogColour = Console.ReadLine();

            Console.WriteLine("Enter dog height");
            int dogHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dog age");
            int dogAge= int.Parse(Console.ReadLine());

            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Colour = dogColour;
            dog.Height = dogHeight;
            dog.Age = dogAge;

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Age);

            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("Enter cat name");
            string catName = Console.ReadLine();

            Console.WriteLine("Enter cat colour");
            string catColour = Console.ReadLine();

            Console.WriteLine("Enter cat height");
            int catHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cat age");
            int catAge = int.Parse(Console.ReadLine());

            Cat cat = new Cat();
            cat.Name = catName;
            cat.Colour = catColour;
            cat.Height = catHeight;
            cat.Age = catAge;

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);

            cat.Eat();
            Console.WriteLine(cat.Cry());

            List <IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();
        }
    }
}
