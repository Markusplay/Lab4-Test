using Lab4_Test.Interfaces;

namespace Lab4_Test.Root
{
    public class TextComposite
    {
        private List<ITextCompositeItem> children;
        public TextComposite()
        {
            children = new List<ITextCompositeItem>();
        }
        public void Add(ITextCompositeItem subItem)
        {
            children.Add(subItem);
        }
        public void Remove(ITextCompositeItem subItem)
        {
            children.Remove(subItem);
        }

        public void Display()
        {
            foreach (ITextCompositeItem item in children)
            {
                item.Display();
            }
        }
    }
}
