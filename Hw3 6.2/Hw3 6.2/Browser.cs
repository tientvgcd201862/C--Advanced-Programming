namespace Hw3_6._2
{
    internal class Browser : IBrowser
    {
        public void Browse(string site)
        {
            Console.WriteLine("Browsing: " + site + "!");
        }
    }
}