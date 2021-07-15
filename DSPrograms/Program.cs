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
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }
        }
       
    }
}
