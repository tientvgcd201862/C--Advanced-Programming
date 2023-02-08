namespace Cars
{
    internal interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        void Start();
        void Stop();
    }
}