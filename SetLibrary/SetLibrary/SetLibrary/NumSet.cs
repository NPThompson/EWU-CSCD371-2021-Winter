using System;

namespace SetLibrary
{
    using List = System.Collections.Generic.LinkedList<int>;

    public class NumSet
    {
        List Elements;

        public NumSet(params int[] elements)
        {
            Elements = new();

            foreach(int i in elements)
            {
                if(!Elements.Contains(i))
                    Elements.AddFirst(i);
            }
        }

        public bool Contains(int element)
        {
            return Elements.Contains(element);
        }
    }
}
