//Written by Duc Anh Dang
//04/07/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfBalloons
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            //using dict for this
            Dictionary<char, double> map = new Dictionary<char, double>();
            map.Add('b', 0);
            map.Add('a', 0);
            map.Add('l', 0);
            map.Add('o', 0);
            map.Add('n', 0);
            for (int i = 0; i < text.Length; i++)
            {
                //check text contain any char in map or not
                if (map.ContainsKey(text[i]))
                {
                    //if l and o, increase 0.5 because ballon have 2 l with 2 0
                    if (text[i] == 'l' || text[i] == 'o')
                    {
                        map[text[i]] += 0.5;
                    }
                    //another only increase 1
                    else
                    {
                        map[text[i]] += 1;
                    }
                }

            }
            //find min value in dict to know how many balloon we have
            double min = map['b'];
            foreach (char c in map.Keys)
            {
                {
                    if (map[c] > min)
                    {
                        min = map[c];
                    }
                }
            }
            return (int)min;
        }
    }
}
