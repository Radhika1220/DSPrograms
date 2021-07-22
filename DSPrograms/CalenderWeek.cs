using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class CalenderWeek<T> 
    {
        public string date;
        public string day;
        public CalenderWeek<T> next;
        CalenderWeek<T> head;
        public CalenderWeek(string days, string dates)
        {
            this.date = dates;
            this.day = days;
            this.next = null;
        }

        public CalenderWeek()
        {
            return;
        }

        public void InsertLast(CalenderWeek<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                CalenderWeek<T> temp = GetLastNode();
                temp.next = newNode;

            }
        }
        //Return Last node in Linked List
        public CalenderWeek<T> GetLastNode()
        {
            CalenderWeek<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void DisplayWeek()
        {
            CalenderWeek<T> temp = head;
            while (temp != null)
            {
                if (temp.date == "")
                {
                    Console.Write("    ");
                    temp = temp.next;
                    continue;
                }

                Console.Write(temp.date);
                if (temp.date.Length >= 2)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("   ");
                }
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }

        public void InsertFront(CalenderWeek<T> newNode)
        {
            CalenderWeek<T> temp = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        //Pop operation for stack
        public CalenderWeek<T> DeQueue(CalenderWeek<T> stack)
        {
            CalenderWeek<T> temp = head;
            stack.InsertFront(temp);
            return stack;
        }
    }
}
