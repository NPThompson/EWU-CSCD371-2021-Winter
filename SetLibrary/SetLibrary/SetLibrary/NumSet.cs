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

        

        public static bool operator !=(NumSet numSet1, NumSet numSet2)
        {
            return !(numSet1 == numSet2);
        }

        public static bool operator ==(NumSet? numSet1, NumSet? numSet2)
        {
            if (numSet1 is null)
                return numSet2 is null;

            return numSet1.Equals(numSet2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;

            if (obj is not NumSet)
                return false;

            NumSet other = (NumSet)obj;

            foreach (int i in Elements)
                if (!other.Contains(i))
                    return false;

            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
