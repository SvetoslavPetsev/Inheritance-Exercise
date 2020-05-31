namespace Animals
{
    using System;
    using System.Text;

    public abstract class Animal
    {
        private const string ERROR_MESSAGE = "Invalid Input!";
        private string name;
        private int age;
        private string gender;
        public Animal()
        {
        }
        public Animal(string name, int age, string gander)
        {
            this.Name = name;

            this.Age = age;

            this.Gender = gander;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    GetThrowExceptionMassage();
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    GetThrowExceptionMassage();
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                if (value != "Male" && value != "Female")
                {
                    GetThrowExceptionMassage();
                }
                this.gender = value;
            }

        }
        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{ProduceSound()}");
            return sb.ToString().TrimEnd();
        }

        public void GetThrowExceptionMassage()
        {
            throw new ArgumentException(ERROR_MESSAGE);
        }
    }
}
