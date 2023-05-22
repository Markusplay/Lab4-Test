using Lab4_Test.Interfaces;

namespace Lab4_Test.Leaves
{
    public class Word : ISentenceItem, IHeaderItem
    {
        private string _word;
        public Word(string word)
        {
            _word = word;
        }
        public void Display()
        {
            Console.Write(_word);
            Console.Write(" ");
        }
    }
}
