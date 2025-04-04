using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
           Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if(map.ContainsKey(temp))
                {
                    return [map[temp], i];
                }
                map[nums[i]] = i;
            }
            
            return null;
        }
    }
}
