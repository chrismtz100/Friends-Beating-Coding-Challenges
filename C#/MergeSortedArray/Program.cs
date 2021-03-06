﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    class Program
    {
        static int[] mergeSortedArrays(int[] array1, int[] array2)
        {
            int totalSize = array1.Length + array2.Length;
            Console.WriteLine(totalSize);
            if (array1.Length == 0)
            {
                return array2;
            }
            else if (array2.Length == 0)
            {
                return array1;
            }
            else if (array1.Length == 0 && array2.Length == 0)
            {
                return array1; //doesn't matter
            }


            int[] sortedArray = new int[totalSize];
            int pos = 0;
            int count1 = 0;
            int count2 = 0;

            while (count1 < array1.Length && count2 < array2.Length)
            {
                int array1Item = array1[count1];
                int array2Item = array2[count2];
                //Console.WriteLine("BEFORE: pos = " + pos + " count1 = " + count1 + " count2 = " + count2 + " array1item = " + array1Item + " array2Item = " + array2Item);
                if (array1Item <= array2Item)
                {
                    sortedArray[pos] = array1Item;
                    count1++;
                }
                else if (array1Item >= array2Item)
                {
                    sortedArray[pos] = array2Item;
                    count2++;
                }
                pos++;
                //Console.WriteLine("AFTERR: pos = " + pos + " count1 = " + count1 + " count2 = " + count2 + " array1item = " + array1Item + " array2Item = " + array2Item);
                //Console.WriteLine("");
            }

            while (count1 < array1.Length)
            {
                sortedArray[pos++] = array1[count1++];
            }

            while (count2 < array2.Length)
            {
                sortedArray[pos++] = array2[count2++];
            }

            return sortedArray;
        }
        static void Main(string[] args)
        {
            int[] array1Int = new[] { 0, 3, 4, 31 }; //4
            int[] array2Int = new[] { 4, 6, 30 }; //3

            int[] sortedArray = mergeSortedArrays(array1Int, array2Int);

            foreach (int item in sortedArray)
            {
                Console.Write(item + " _ ");
            }

        }
    }
}
