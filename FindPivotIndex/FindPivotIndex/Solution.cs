//Written by Duc Anh Dang
//04/16/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int totalSum = 0;
        int leftSum = 0;

        foreach (int num in nums)
        {
            totalSum += num;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = totalSum - nums[i] - leftSum;
            if(leftSum == rightSum)
            {
               return i;
            }
            leftSum += nums[i];
                   
        }
        return -1; 
    }
}
