//Written by Duc Anh Dang
//04/07/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotReturnToOrigin
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int count = 0;
            //check
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                {
                    count++;
                }
                if (moves[i] == 'D')
                {
                    count--;
                }
                if (moves[i] == 'L')
                {
                    count++;
                }
                if (moves[i] == 'R')
                {
                    count--;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
