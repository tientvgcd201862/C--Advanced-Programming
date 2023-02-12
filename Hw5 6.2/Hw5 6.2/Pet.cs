namespace Hw5_6._2
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Pet(string s, string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public Pet()
        {
        }
    }
}