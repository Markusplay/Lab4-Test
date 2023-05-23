using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class Listing : Item
    {
        public Listing(string name) : base(name)
        {
        }

        public override void Add(Item subItem)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("\n```");
            Console.Write(name);
            Console.WriteLine("\n```");
        }

        public override void Remove(Item subItem)
        {
            throw new NotImplementedException();
        }
    }
}
