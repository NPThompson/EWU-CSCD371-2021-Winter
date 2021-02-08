using System;

namespace GenericsHomework
{
    public class Node<T>
    {
        public Node(T init) 
        {
            this.data = init;
            this.Next = this;
        }
        
        public Node()
        {
            this.Next = this;
        }

        public T? data;
        public Node<T> Next { get; private set; }


        public override string ToString()
        {
            return this.data?.ToString() ?? "";
        }

        public void Insert(Node<T> newNext)
        {
            newNext.Next = this.Next;
            this.Next = newNext;
        }

        public void Clear()
        {
            // This is all that is necessary
            this.Next = this;

            // Because, while the cleared Nodes still reference this, this does not reference them
            // The garbage collector will not be able to find them, so will get rid of them
        }

    }
}
