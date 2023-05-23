using Lab4_Test.Interfaces;

namespace Lab4_Test.Leaves
{
    public class Word : Item
    {

        public Word(string name) : base(name)
        {
        }

        public override void Add(Item subItem)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.Write(name);
            Console.Write(" ");
        }

        public override void Remove(Item subItem)
        {
            throw new NotImplementedException();
        }
    }
}
