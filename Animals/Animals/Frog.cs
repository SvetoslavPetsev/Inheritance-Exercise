namespace Animals.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gander) 
            : base(name, age, gander)
        {

        }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
