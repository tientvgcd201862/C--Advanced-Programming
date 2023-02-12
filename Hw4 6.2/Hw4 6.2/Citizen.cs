namespace Hw4_6._2
{
    internal class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            ID = id;
        }
        public Citizen()
        {

        }
    }
}