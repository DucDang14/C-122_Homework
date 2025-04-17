//Written by Duc Anh Dang
//04/16/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            //use stack for check 
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(')');
                }
                else if (s[i] == '[')
                {
                    stack.Push(']');
                }
                else if (s[i] == '{')
                {
                    stack.Push('}');
                }
                else if (stack.Count == 0 || s[i] != stack.Pop())
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
