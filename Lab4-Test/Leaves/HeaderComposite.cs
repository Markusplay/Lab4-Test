using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class HeaderComposite: Item
    {
        private List<Item> children = new();

        public HeaderComposite(string name) : base(name)
        {
        }

        public override void Add(Item subItem)
        {
            children.Add(subItem);
        }
        public override void Remove(Item subItem)
        {
            children.Remove(subItem);
        }
        public override void Display()
        {
            Console.Write("\t\t");
            foreach (Item item in children)
            {
                item.Display();
            }
        }
    }
}
