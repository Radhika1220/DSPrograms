using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
  public  class PrimeNumInRange
    {
        public static int range = 0, index = 0, c = 0;
        public static void IsPrimeChecker(int start, int end)
        {
            int[,] primeNumbers = new int[10, 1000];
            for (int i = start + 1; i <= end; i++)
            {
                if (i > 100)
                {
                    string temp = Convert.ToString(i);
                    char ind = temp[0];
                    range = Convert.ToInt32(ind) - 48;

                }
                if (c != range)
                {
                    index = 0;
                    c = range;
                }
                int flag = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i != 0 && i != 1 && j != 0 && j != 1 && (i % 2 == 0 || i % j == 0))
                  
                    { flag = 1;
                        break;
                     
                    }
                }
               if (i != 1 && (flag != 1 || i == 2))
         
                {
                    primeNumbers[range, index] = i;
                    index++;
                }
            }
            Console.WriteLine("\n************ Printing Prime Number in Range ({0} - {1}) **********", start, end);
            //Print prime numbers in range 0-1000
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    if (primeNumbers[a, b] != 0)
                    {
                        Console.Write(primeNumbers[a, b] + " ");
                    }
                }
            }

        }
    }
}