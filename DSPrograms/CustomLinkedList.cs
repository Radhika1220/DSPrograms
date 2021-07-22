using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
  public  class CustomLinkedList<T> where T :IComparable
    {
        public Node<T> head;
        public Node<T> top;
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

        public void Push(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
           // Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                //return;
            }
            Console.WriteLine("The element after peeking is : " + this.top.data);
           
        }
        //Pop Mthod-Removes the top most element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }

        public int CountFn()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (this.top==null)
            {
                Console.WriteLine("No elements present in the stack");
            }
            else
            {
                temp = temp.next;
                count++;
            }
            return count;
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

        public void  PushDisplay()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
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
        public void Enqueue(T item)
        {
            Node<T> new_node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
        }
        public void Dequeue()
       {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node<T> temp = this.head;
            this.head = this.head.next;
      
        }
        public string DequeuePalindromeChecker()
        {
            string reverseString = " ";
            while (this.head != null)
            {
                if (this.head == null)
                {
                    Console.WriteLine("Queue is empty");
                }

                reverseString = this.head.data + reverseString;
                head = head.next;
            }
            return reverseString;
        }
        public int IsEmpty()
        {
            if (this.head!= null)
            {
                return 1;
            }
            else
            {
                return 0;
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
