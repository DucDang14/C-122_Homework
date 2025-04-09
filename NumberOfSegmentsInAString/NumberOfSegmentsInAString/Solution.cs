//Written by Duc Anh Dang
//04/07/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSegmentsInAString
{
    public class Solution
    {
        public int CountSegments(string s)
        {
            int count = 0;
            //use for loop
            for (int i = 1; i < s.Length; i++)
            {
                //check is the index before is space or not, increase count if it is space
                if (i == 0 || s[i - 1] == ' ' && s[i] != ' ')
                {
                    count++;
                }
            }
            return count;
            
            
        }
    }
}
