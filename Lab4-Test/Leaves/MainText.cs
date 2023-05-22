using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class MainText : ITextCompositeItem
    {
        private List<IMainTextItem> children;
        public MainText()
        {
            children = new List<IMainTextItem>();
        }
        public void Add(IMainTextItem subItem)
        {
            children.Add(subItem);
        }
        public void Remove(IMainTextItem subItem)
        {
            children.Remove(subItem);
        }
        public void Display()
        {
            foreach (IMainTextItem item in children)
            {
                item.Display();
            }
        }
    }
}
