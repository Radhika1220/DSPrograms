using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DSPrograms
{
    class HashingList
    {
       public static int size;

        public static void HashList()
        {
            size = 11;
            
            string text = File.ReadAllText(@"C:\Users\Radhika\source\repos\DSPrograms\DSPrograms\HashWordList.txt");
            string[] textNum = text.Split(" ");
            HashSlot<int> hashSlot = new HashSlot<int>(size);
            for (int i=0;i<textNum.Length;i++)
            {
                hashSlot.Add(Convert.ToInt32(textNum[i]));
            }
            hashSlot.Display();
            Console.WriteLine("\nEnter a number which you want to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            if(hashSlot.Search(searchNum)==1)
            {
                Console.WriteLine("Element is present ");
            }
            else
            {
                hashSlot.Add(searchNum);
            }
          
            File.WriteAllText(@"C:\Users\Radhika\source\repos\DSPrograms\DSPrograms\HashWordList.txt",hashSlot.Display());
          
        }
    }
}
