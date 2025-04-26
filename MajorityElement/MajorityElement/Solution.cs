//Written by Duc Anh Dang
//04/23/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            int check = nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map[nums[i]] = 1;
                }
                if (map[nums[i]] > check)
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}
