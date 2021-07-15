using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    class BankingCashCounter
    {
        public int bankBal = 1500;
        public void MaintainQueue()
        {
            Console.WriteLine("Enter the number of persons in Queue");
            int persons = Convert.ToInt32(Console.ReadLine());
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            for (int i=1;i<=persons;i++)
            {
                Console.WriteLine("People {0} ", i);
                list.Enqueue(i);
                WithdrawalAndDeposit();
                list.Dequeue();
            }
            if(list.IsEmpty()==0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue is not empty");
            }
            Console.WriteLine("Current Balance : " + bankBal);
        }
        public void WithdrawalAndDeposit()
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Withdrawal cash");
                Console.WriteLine("2.Deposit Cash");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                  case 1:
                    Console.WriteLine("Enter amount to withdrawal");
                    int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                     bankBal = bankBal - withdrawalAmount;
                     
                   break;
                   case 2:
                        Console.WriteLine("Enter amount to deposit");
                        int amountDeposit = Convert.ToInt32(Console.ReadLine());
                        bankBal = bankBal + amountDeposit;
                    break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }
          
        }
    }
}
