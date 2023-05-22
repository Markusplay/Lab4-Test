using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class Listing : ITextCompositeItem
    {
        private string _listing;
        public Listing(string listing)
        {
            _listing = listing;
        }
        public void Display()
        {
            Console.WriteLine("\n```");
            Console.Write(_listing);
            Console.WriteLine("\n```");
        }
    }
}
