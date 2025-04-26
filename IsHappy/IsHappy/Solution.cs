
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsHappy
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> map = new HashSet<int>();
            while (!map.Contains(n))
            {
                map.Add(n);
                n = GetNextNumber(n);
                if (n == 1)
                {
                    return true;
                }
            }
            return false;
        }
        private int GetNextNumber(int n)
        {
            int output = 0;
            while (n > 0)
            {
                int digit = n % 10;
                output += digit * digit;
                n = n / 10;
            }
            return output;
        }
    } 
}