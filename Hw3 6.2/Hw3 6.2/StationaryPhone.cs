namespace Hw3_6._2
{
    internal class StationaryPhone : IPhone
    {
        public void Call(string number)
        {
            Console.WriteLine("Dialing... " + number);
        }
    }
}