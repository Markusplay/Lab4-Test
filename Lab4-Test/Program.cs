﻿using Lab4_Test.Leaves;
using Lab4_Test.Root;

namespace Lab4_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TextComposite text = new TextComposite();

            Header header = new Header();

            Paragraph paragraph = new Paragraph();
            Paragraph paragraph2 = new Paragraph();

            Listing listing = new Listing("Listing code");

            Sentence sentence = new Sentence();
            Sentence sentence2 = new Sentence();

            MainText main = new MainText();

            Word hello = new Word("Hello");
            Word world = new Word("world");

            Punctuation dot = new Punctuation('.');


            Word I = new Word("I");
            Word feel = new Word("feel");
            Word good = new Word("good");

            header.Add(hello);

            sentence.Add(hello);
            sentence.Add(world);
            sentence.Add(dot);

            sentence2.Add(I);
            sentence2.Add(feel);
            sentence2.Add(good);
            sentence2.Add(dot);


            main.Add(sentence);
            main.Add(sentence2);

            header.Add(paragraph);

            text.Add(header);
            text.Add(main);
            text.Add(listing);
            text.Add(main);
            text.Add(main);
            text.Display();
            Console.WriteLine("\n----------------------------------------------");

            text.Remove(main);
            text.Display();
        }
    }
}