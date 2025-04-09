//Written by Duc Anh Dang
//04/07/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            //vars
            string merged = "";
            int tempLength = 0;
            //find which string is bigger
            if (word1.Length > word2.Length)
            {
                tempLength = word1.Length;
            }
            else 
            {
                tempLength = word2.Length;
            }
            //add char into new string
            for (int i = 0; i < tempLength; i++)
            {
                
                if(i < word1.Length)
                {
                    merged += word1[i];
                }
                if(i < word2.Length)
                {
                    
                    merged += word2[i];
                }
            }
            return merged;
        }
    }
}
