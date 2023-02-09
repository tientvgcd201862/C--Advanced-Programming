namespace Animals
{
    public abstract class Animal
    {    // Create Constructor

        protected Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }
        public virtual string ExplainSelf()
        {
            return string.Format(
              "I am {0} and my favourite food is {1}",
              this.Name,
              this.FavouriteFood);
        }
    }
}