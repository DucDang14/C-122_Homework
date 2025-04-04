using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindtheIndexOfTheFirstOccurrenceInAString
{
    public class Solution
    {
        public int Check(string haystack, string needle)
        {
            //var
            int LengthI = haystack.Length + 1 - needle.Length;
            //for loop
            for (int i = 0; i < LengthI; i++)
            {
                //run through needle
                for(int j = 0; j < needle.Length; j++)
                {
                    //if this !=, it will break inside loop to check the next one
                    if (haystack[i+j] != needle[j])
                    {
                        break;
                    }
                    //check is that needle finish or not
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            //if dont have any needle in stack return -1
            return -1;

        }
    }
}
