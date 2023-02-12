namespace Hw4_6._2
{
    internal class Robot
    {
        public string Model { get; set; }
        public string ID { get; set; }

        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }
        public Robot()
        {

        }
    }
}