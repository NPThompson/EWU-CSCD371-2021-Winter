using System;

namespace GenericsHomework
{
    public class Node<T>
    {
        public Node(T init) 
        {
            this.data = init;
            this.next = this;
        }
    
        private T data;
        private Node<T> next;

      
    }
}
