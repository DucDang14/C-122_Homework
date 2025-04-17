//Written by Duc Anh Dang
//04/16/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int CalPoints(string[] operations)
    {
        Stack<int> stack = new Stack<int>();
        int total = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "+")
            {
                int top = stack.Pop();
                int newTop = stack.Peek() + top;
                stack.Push(top);
                stack.Push(newTop);
            }
            else if (operations[i] == "D")
            {
                stack.Push(stack.Peek() * 2);
            }
            else if (operations[i] == "C")
            {
                stack.Pop();
            }
            else
            {
                stack.Push(Convert.ToInt32(operations[i]));
            }
        }
        for (int i = 0; i < stack.Count; i++)
        {
            total = total + stack.Pop();
            i--;
        }
        return total;
    }
}
