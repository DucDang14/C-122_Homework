//Written by Duc Anh Dang
//04/07/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqueCharacterInAString
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            //create a dict
            Dictionary<char, int> map = new Dictionary<char, int>();
            //keys is char in string, values is 0
            foreach (char c in s)
            {
                map[c] = 0;
            }
            //increase value
            for(int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
            }
            //the first value = 1 will return that index
            for(int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1)
                {
                    return i;
                }
            }
            //return when do not have
            return -1;
        }
    }
}
