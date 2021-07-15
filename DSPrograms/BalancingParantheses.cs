using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    /// <summary>
    /// Balancing Parantheses using stack 
    /// </summary>
    class BalancingParantheses
    {
        public class StackOperations
        {
            char[] item;
            int top = -1;
            //Push method 
            public bool Push(char x)
            {
                if (top == item.Length)
                {
                    return false;
                }
                else
                {
                    item[++top] = x;
                    return true;
                }
            }
            //Pop method
            public char Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Underflow error");
                    return '\0';
                }
                else
                {
                    char element = item[top];
                    top--;
                    return element;
                }
            }
            //To check the matching characters to pop from stack
            public bool MatchingChar(char char1, char char2)
            {
                if (char1 == '[' && char2 == ']')
                    return true;
                else if (char1 == '{' && char2 == '}')
                    return true;
                else if (char1 == '(' && char2 == ')')
                    return true;
                else
                    return false;
            }
            //Balance method to perform push and pop operation for opening and closing parantheses
            public bool Isbalanced(char[] exp)
            {
                item = new char[exp.Length];
                bool flag = true;
                if (exp.Length == 0)
                    return true;

                for (int i = 0; i < exp.Length; i++)
                {
       
                    if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    {
                        Push(exp[i]);
                        flag = false;
                    }
                    if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                    {
                        if (MatchingChar(Pop(), exp[i]))
                            flag = true;
                        else
                            return false;
                    }
                }
                return flag;
            }
        }

    }
}
