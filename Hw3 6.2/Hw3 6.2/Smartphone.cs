namespace Hw3_6._2
{
    internal class Smartphone : IPhone
    {
        public void Call(string number)
        {
            Console.WriteLine("Calling... " + number);
        }
    }
}