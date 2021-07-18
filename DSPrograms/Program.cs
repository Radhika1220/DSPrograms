﻿using System;

namespace DSPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Programs!");
            Console.WriteLine("1.Unordered List");
            Console.WriteLine("2.Ordered List");
            Console.WriteLine("3.Balancing Parantheses");
            Console.WriteLine("4.Banking Cash Counter");
            Console.WriteLine("5.Print calender format");
            Console.WriteLine("6.Palindrome Checker");
            Console.WriteLine("7.Number of binary search tree");
            Console.WriteLine("Hash Slot");
            int check = Convert.ToInt32(Console.ReadLine());
            switch(check)
            {
                case 1:
                    UnorderdList.Unordered();
                    break;
                case 2:
                    OrderedList.Ordered();
                    break;
                case 3:
                    char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                    BalancingParantheses.StackOperations stackOperations = new BalancingParantheses.StackOperations();
                    bool result=stackOperations.Isbalanced(expression);
                    if(result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }
                    break;
                case 4:
                    BankingCashCounter banking = new BankingCashCounter();
                    banking.MaintainQueue();
                    break;
                case 5:
                    Calender.PrintCalender();
                    break;
                case 6:
 
                    PalindromeChecker<char> checker = new PalindromeChecker<char>();
                    checker.IsPalindrome();
                    break;
                case 7:
                    Console.WriteLine("Enter the number : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number of structurally Unique BST with " + n + " keys are : " + NoOfUniqueBinarySearchTree.numberOfBST(n));
                    break;
                case 8:
                    HashingList.HashList();
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }
        }
       
    }
}
