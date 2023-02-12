namespace Hw5_6._2
{
    internal class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string Birthday { get; set; }
        public Citizen(string s, string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthday = birthday;
        }
        public Citizen()
        {
        }
    }
}