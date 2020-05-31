namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            if (age >= 0)
            {
                this.Age = age;
            }
            this.Name = name;
        }

        public int Age { get; protected set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
