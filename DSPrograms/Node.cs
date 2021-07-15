using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;
        public int idata;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
            idata = Convert.ToInt32(data);
        }
    }
}