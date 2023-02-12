namespace Hw1_6._2
{
    internal class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen()
        {

        }
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} are {this.Age} years old.";
        }

    }
}