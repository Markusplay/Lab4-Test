using Lab4_Test.Interfaces;

namespace Lab4_Test.Leaves
{
    public class Punctuation : ISentenceItem
    {
        private char _symbol;
        public Punctuation(char symbol)
        {
            _symbol = symbol;
        }
        public void Display()
        {
            Console.Write(_symbol);
        }
    }
}
