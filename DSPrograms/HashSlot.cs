using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DSPrograms
{
    class HashSlot<T>
    {
        //Linked List to store values of say index
        private int size=11;
        private LinkedList<T>[] item;
  
        public HashSlot(int size)
        {
            this.size = size;
            this.item = new LinkedList<T>[11];
        }


        //Add Node: Get Array Position ->Get linked list
        public  void Add(T val)
        {
            int pos = GetArrayPosition(val);
            LinkedList<T> list = GetLinkedList(pos);
            list.AddLast(val);
        }
        //Step 1: Get slot number by %size
        public  int GetArrayPosition(T key)
        {
            size = 11;
            int hashcode = key.GetHashCode();
            int position = hashcode % size;
            return Math.Abs(position);
        }
        //Step 2: Get Linked List
        protected LinkedList<T> GetLinkedList(int position)
        {
            LinkedList<T> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<T>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        //method to display element in each slot
        public string Display()
        {
            string result = "";
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                LinkedList<T> linkedList = item[i];
                if (linkedList == null)
                {
                    continue;
                }
                foreach (T value in linkedList)
                {
                    Console.WriteLine("Element {0} of Hash Table is: {1}", count, value);
                    result = value.ToString() + " " + result;
                    count++;
                }
            }
            return result;
        }
    
    public int Search(T value)
    {
        int position = GetArrayPosition(value);
        LinkedList<T> linkedList = GetLinkedList(position);
        if (linkedList == null)
        {
            return -1;
        }
        else
        {
            int flag = 0;
            foreach (T i in linkedList)
            {
                if (i.Equals(value))
                {
                        flag = 1;
                        
                }
            }
            return flag;
        }
    }
}
}