using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class PrimeNumInRange
    {

        public static int[,] AnagramNum = new int[10, 100];
        public static int[,] NotAnagramNum = new int[10, 100];
        public static int range, change, index = 0;
        public static int[,] primeNum = new int[10, 100];
        static CustomLinkedList<int> list = new CustomLinkedList<int>();
        //Checking prime number
        public static void IsPrimeChecker(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                if (i > 100)
                {
                    string tempStr = Convert.ToString(i);
                    char firstChar = tempStr[0];
                    range = Convert.ToInt32(firstChar) - 48;

                }


                if (change != range)
                {
                    index = 0;
                    change = range;
                }
                int found = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i != 0 && i != 1 && j != 0 && j != 1 && (i % 2 == 0 || i % j == 0))
                    {
                        found = 1;
                        break;
                    }
                }
                if (i != 1 && (found != 1 || i == 2))
                {
                    primeNum[range, index] = i;
                    index++;
                }
            }
            //Extending Program to find anagrams

            Console.WriteLine("\n*********** Printing Prime Number From  {0} to  {1}  **********", start, end);
            Console.WriteLine("\n");
            change = 0;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 100; b++)
                {
                    if (primeNum[a, b] != 0)
                    {
                        Console.Write(primeNum[a, b] + " ");
                        Console.Write(" ");
                        if (primeNum[a, b] > 100)
                        {
                            string tempStr1 = Convert.ToString(primeNum[a, b]);
                            char firstChar = tempStr1[0];
                            range = Convert.ToInt32(firstChar) - 48;

                        }

                        if (change != range)
                        {
                            index = 0;
                            change = range;
                        }
                        char[] firstTemp = primeNum[a, b].ToString().ToCharArray();
                        Array.Sort(firstTemp);
                        int secondStr = 0;
                        int firstStr = Convert.ToInt32(String.Join("", firstTemp));
                        int q;
                        for (q = b + 1; q < 100; q++)
                        {
                            char[] secondTemp = primeNum[a, q].ToString().ToCharArray();
                            Array.Sort(secondTemp);
                            secondStr = Convert.ToInt32(String.Join("", secondTemp));
                            if (firstStr == secondStr)
                            {
                                break;
                            }
                        }
                        if (secondStr == firstStr)
                        {
                            AnagramNum[range, index] = primeNum[a, b];
                            list.Push(primeNum[a, b]);
                            list.Enqueue(primeNum[a, b]);
                            index++;
                            AnagramNum[range, index] = primeNum[a, q];
                            list.Push(primeNum[a, q]);
                            list.Enqueue(primeNum[a, q]);
                            index++;

                        }
                    }
                }
            }
            PrintingAnagramInReverse(0, 1000);
            PrintingAnagramUsingQueue(0, 1000);

        }
        //Printing the anagram in reverse order using stack 
        public static void PrintingAnagramInReverse(int start,int end)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n ****** Printing the Anagram in Reverse Order(Using Stack Operations) From {0} to {1} **** ", start, end);
            Console.WriteLine("\n");
            list.PushDisplay();

        }
        //Printing the anagram using queue operations
        public static void PrintingAnagramUsingQueue(int start,int end)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n ****** Printing the Anagram (Using Queue Operations) From {0} to {1} ********* ", start, end);
            list.Display();
        }

        //Printing anagram array
        public static void PrintingAnagram(int start, int end)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n********* Printing Anagram Array From {0} to {1} ***********", start, end);
            Console.WriteLine("\n");
            //Print Array having anagram
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (AnagramNum[k, l] != 0)
                    {
                        Console.Write(AnagramNum[k, l] + " ");
                        Console.Write(" ");
                    }

                }
            }
        }
        //printing non-anagram array
        public static void PrintingNonAnagram(int start, int end)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n************ Printing Non-Anagram Array From {0} to  {1} ************", start, end);
            Console.WriteLine("\n");
            //Print Array having anagram
            int flag = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    flag = 0;
                    if (primeNum[k, l] != 0)
                    {
                        for (int p = 0; p < 10; p++)
                        {
                            for (int m = 0; m < 100; m++)
                            {

                                if (primeNum[k, l] == AnagramNum[p, m])
                                {
                                    flag = 1;
                                    break;
                                }
                            }
                        }
                        if (flag == 0)
                        {
                            NotAnagramNum[k, l] = primeNum[k, l];
                            Console.Write(NotAnagramNum[k, l] + " ");
                            Console.Write(" ");
                        }

                    }
                }
            }

        }
    }
}