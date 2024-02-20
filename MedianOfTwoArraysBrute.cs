using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet75
{
    public class MedianOfTwoArraysBrute
    {
        public static double Median(int[] array1, int[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;


            List<int> array3 = new List<int>();

            //appay the merge step
            int i = 0, j = 0;

            while(i < n1 && j<n2)
            {
                if (array1[i] <array2[j])
                {
                    array3.Add(array1[i++]);
                }
                else
                {
                    array3.Add(array2[j++]);
                }
            }
            // copy the left-out elements 
            while(i<n1)
            {
                array3.Add(array1[i++]);
            }
            while(j<n2)
            {
                array3.Add(array2[j++]);
            }
            // find the median

            int n = n1 + n2;

            if(n%2 == 1)
            {
                return array3[n/2]; 
            }

            return (array3[n / 2] + array2[(n/2)-1])/2;
        }
    }
}
