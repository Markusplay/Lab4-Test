
namespace Lab4_Test.Interfaces
{
    public abstract class Item
    {
        protected string name;
        public Item(string name)
        {
            this.name = name;
        }

        public abstract void Add(Item subItem);
        public abstract void Remove(Item subItem);
        public abstract void Display();
    }
}
