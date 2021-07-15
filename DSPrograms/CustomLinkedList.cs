using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
  public class CustomLinkedList<T> where T :IComparable
    {
        public Node<T> head;

        public bool Search( T val)
        {
            Node<T> temp = this.head;
            while(temp!=null)
            {
                if(temp.data.Equals(val))
                {
                    Console.WriteLine("\nElement Found... " + val);
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertFront(T new_data)
        {
            Node<T> newNode = new Node<T>(new_data);
            newNode.next = this.head;
            this.head = newNode;
            //Console.WriteLine("Inserted the list in front " + newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("\n------Displaying Nodes---------");
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void DeleteElement(T data)
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(data))
                {
                    Console.WriteLine("\nDelete data: {0}", temp.next.data);
                    temp.next = temp.next.next;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
        public void Sort(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            if (head == null || newNode.idata <= head.idata)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next == null && head.idata < newNode.idata)
            {
                head.next = newNode;
            }
            else
            {
                if (temp.next.idata > newNode.idata)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while (temp.next != null && temp.next.idata < newNode.idata)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }

        public string ReturnString()
        {
            string strText = "";
            Node<T> cur = head;
            if(head!=null)
            {
                strText += cur.data;
                cur = cur.next;
                while(cur!=null)
                {
                    strText = strText + " " + cur.data;
                    cur = cur.next;

                }
                return strText;
            }
            else
            {
                Console.WriteLine("Empty!!!");
                return default;
            }
        }
    }
}
