//Written by Duc Anh Dang
//04/23/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int k = s.Length - 1;
            for (int i = 0; i < s.Length - 1 - i; i++)
            {
                char temp = s[i];
                s[i] = s[k];
                s[k] = temp;
                k -= 1;
            }
        }
    }
}
