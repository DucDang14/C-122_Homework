using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int countS = 0;
            int countT = 0;
            int temp = 0;
            //calc number in s string
            foreach(char c in s)
            {
                countS = countS + Convert.ToInt32(c);
            }
            //calc number in t string
            foreach(char c in t)
            {
                countT = countT + Convert.ToInt32(c);
            }
            //check which one is big one and take the big one minus the smaller one
            //and assign to a var 
            if (countT > countS)
            {
                temp = countT - countS;
            }
            else
            {
                temp = countS - countT;
            }
            //convert to char and return it
            return (char)temp;
        }
    }
}
