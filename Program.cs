namespace Ukesoppgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Pet("Tom", 2, "Cat");

            cat.Feed("Tuna");
            cat.Feed("Pizza", true);
            Console.ReadKey();
        }
    }
}