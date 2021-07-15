using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class Node<T>
    {
        public T data;
        public int idata;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
