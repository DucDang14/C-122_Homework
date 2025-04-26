//Written by Duc Anh Dang
//04/23/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[k];
                    nums[k] = temp;
                    k++;
                }
            }
        }
    }
}
