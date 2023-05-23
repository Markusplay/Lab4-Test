using Lab4_Test.Interfaces;

namespace Lab4_Test.Leaves
{
    public class Punctuation : Item
    {
        public Punctuation(string name) : base(name)
        {
        }

        public override void Add(Item subItem)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.Write(name);
        }

        public override void Remove(Item subItem)
        {
            throw new NotImplementedException();
        }
    }
}
