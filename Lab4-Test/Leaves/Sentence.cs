using Lab4_Test.Interfaces;

namespace Lab4_Test.Leaves
{
    public class Sentence: IMainTextItem, IHeaderItem
    {
        private List<ISentenceItem> children;

        public Sentence()
        {
            children = new List<ISentenceItem>();
        }

        public void Add(ISentenceItem subItem)
        {
            children.Add(subItem);
        }
        public void Remove(ISentenceItem subItem)
        {
            children.Remove(subItem);
        }
        public void Display()
        {
            foreach (ISentenceItem item in children)
            {
                item.Display();
            }
            Console.Write(" ");
        }
    }
}
