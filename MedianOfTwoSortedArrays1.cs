using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet75
{
    internal class MedianOfTwoSortedArrays1
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3 };
            int[] array2 = { 2, };

            int median = FindMedianSortedArrays(array1 , array2);
        }

        public static int FindMedianSortedArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = array1.Concat(array2).ToArray();
            Array.Sort(mergedArray);

            int length = mergedArray.Length;

            if (length % 2 == 1)
            { 
                return mergedArray[length / 2];
            }

            return (mergedArray[length / 2] + mergedArray[length/2-1])/2;
        }
    }
}
