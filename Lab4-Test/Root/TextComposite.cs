﻿using Lab4_Test.Interfaces;

namespace Lab4_Test.Root
{
    public class TextComposite: Item
    {
        private List<Item> children = new();

        public TextComposite(string name) : base(name)
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
            foreach (Item item in children)
            {
                item.Display();
            }
        }
    }
}
