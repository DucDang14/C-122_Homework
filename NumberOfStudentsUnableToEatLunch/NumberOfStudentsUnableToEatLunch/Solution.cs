//Written by Duc Anh Dang
//04/16/2025   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStudentsUnableToEatLunch
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int result = students.Length;
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (var student in students)
            {
                if (!count.ContainsKey(student))
                {
                    count[student] = 0;
                }
                count[student] += 1;
            }
            foreach (var s in sandwiches)
            {
                if (count[s] > 0)
                {
                    result--;
                    count[s]--;
                }
                else
                {
                    return result;
                }
               
            }
            return result;
        }
    }
}
