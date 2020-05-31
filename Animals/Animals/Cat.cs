﻿namespace Animals.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gander)
                : base(name, age, gander)
        {
        }
        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
