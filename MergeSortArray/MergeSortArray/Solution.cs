using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortArray
{
    public class Solution
    {
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //Create new arr with length is m+n
            int[] arr = new int[m+n];
            //add to new arr
            for (int i = 0; i < m; i++)
            {
                arr[i] = nums1[i];
            }
            for (int i = 0; i < n; i++)
            {
                arr[m + i] = nums2[i];
            }
            //bubble sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;

                    }
                }
            }
            return arr;
        }
    }
}
