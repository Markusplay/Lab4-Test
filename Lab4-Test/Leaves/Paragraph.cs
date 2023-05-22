using Lab4_Test.Interfaces;
namespace Lab4_Test.Leaves
{
    public class Paragraph: IHeaderItem
    {
        private List<Sentence> children;

        public Paragraph()
        {
            children = new List<Sentence>();
        }
        public void Add(Sentence subItem)
        {
            children.Add(subItem);
        }
        public void Remove(Sentence subItem)
        {
            children.Remove(subItem);
        }
        public void Display()
        {
            Console.Write("\n\t");
            foreach (Sentence item in children)
            {
                item.Display();
            }
        }
    }
}
