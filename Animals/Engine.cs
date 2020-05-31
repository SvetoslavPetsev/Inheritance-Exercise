namespace Animals
{
    using Animals;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private readonly List<Animal> animals;
        private const string END_PROGRAM_WORD = "Beast!";

        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string type;
            while ((type = Console.ReadLine()) != END_PROGRAM_WORD)
            {
                string[] animalArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal animal;

                try
                {
                    animal = GetAnimal(type, animalArg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                this.animals.Add(animal);
            }
            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static Animal GetAnimal(string type, string[] info)
        {
            Animal animal;

            string name = info[0];
            int age = int.Parse(info[1]);
            string gender = null;

            if (info.Length >= 3)
            {
                gender = info[2];
            }

            if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }

            else if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }

            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }

            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }

            else if (type == "Kitten")
            {
                animal = new Kitten(name, age);
            }

            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }

    }
}
