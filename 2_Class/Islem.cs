using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class
{
    internal class Islem
    {
        internal int[] nums;
        internal void Sort()
        {
            Print(); // dizinin elemanlarını yazdır..
            Console.WriteLine("***SIRALAMA BAŞLADI***");
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                    Console.WriteLine("***");
                    Print(); // elemanları yazdır... (hocanın tavsiyesi...)
                }
            }
            Console.WriteLine("***SIRALAMA BİTTİ***");
        }

        internal void Print()
        {
            foreach (var item in nums)
                Console.Write(item + " ");
        }
    }
}