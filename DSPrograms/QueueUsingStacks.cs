
using System;
using System.Collections;
using System.Collections.Generic;

namespace DSPrograms
{
    public class QueueUsingStacks
    {
        public void GetInput()
        {
            //Create object for Calendar Class
            Calendar calendar = new Calendar();
            //Create Stack Week Objects
            Queue<CalenderWeek<Calendar>> Stackqueue = calendar.Stack();
            int n = Stackqueue.Count;
            //Use another Stack to implement queue using two stacks
            for (int i = 0; i < n; i++)
            {
                CalenderWeek<Calendar> StackQueue = new CalenderWeek<Calendar>();
                Stackqueue.Dequeue().DeQueue(StackQueue);
                Stackqueue.Enqueue(StackQueue);
            }
            //Display Calendar using Two stacks implementation
            Console.WriteLine("----------Queue using Two Stacks for week objects--------");
            calendar.DisplayCalender();
            foreach (var i in Stackqueue)
            {
                i.DisplayWeek();
            }
        }
    }
}