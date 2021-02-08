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
            this.Next = newNext;
        }

    }
}
