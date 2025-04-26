//Written by Duc Anh Dang
//04/23/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if(s[i] != ' ')
                {
                    count++;
                }
                if(count > 0 && s[i] == ' ')
                {
                    break;
                }
            }
            return count;
        }
    }
}
