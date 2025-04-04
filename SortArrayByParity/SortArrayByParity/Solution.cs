using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParity
{
    internal class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //swap odd number by even number at the begining
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[k];
                    nums[k] = nums[i];
                    nums[i] = temp;
                    k++;
                }
            }
            
            return nums;
        }
    }
}

