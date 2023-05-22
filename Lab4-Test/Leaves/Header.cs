using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class Header: ITextCompositeItem
    {
        private List<IHeaderItem> children;
        public Header()
        {
            children = new List<IHeaderItem>();
        }
        public void Add(IHeaderItem subItem)
        {
            children.Add(subItem);
        }
        public void Remove(IHeaderItem subItem)
        {
            children.Remove(subItem);
        }
        public void Display()
        {
            Console.Write("\t\t");
            foreach (IHeaderItem item in children)
            {
                item.Display();
            }
        }
    }
}
