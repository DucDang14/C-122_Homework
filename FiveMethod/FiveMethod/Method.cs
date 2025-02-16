using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FiveMethod
{
    internal class Method
    {
        //find min in list
        public int FindMin(List<int> numList)
        {
            int min = numList[0];
            foreach (int num in numList)
            {
                if (min > num)
                {
                    min = num;
                }
            }
            return min;
        }
        //find max in list
        public int FindMax(List<int> numList)
        {
            int max = numList[0];
            foreach (int num in numList)
            {
                if (max < num)
                {
                    max = num;
                }
            }
            return max;
        }
        //access to FindMin and FindMax function 
        public List<int> FindMinMax(List<int> numList) 
        {
            List<int> newList = new List<int>();
            int min = FindMin(numList);
            int max = FindMax(numList);
            newList.Add(min);
            newList.Add(max);
            return newList;

        }
        //calculate the sum with absolute value in array
        public int GetAbsSum(int[] arr)
        {
            int total = 0;
            foreach (int num in arr)
            {
                total += Math.Abs(num);
            }
            return total;
        }
        //Multiply element with array length 
        public int[] MultiplyByLength(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i] * arr.Length;
            }
            return newArr;
        }
        //Find smaller number
        public string smallerNum(string a, string b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            if (num1 > num2)
            {
                return Convert.ToString(num2);
            }
            else if (num1 < num2)
            {
                return Convert.ToString(num1);
            }
            else
            {
                return Convert.ToString(num1);
            }

        }
        //count D in sentence
        public int CountDs(string sense)
        {
            int count = 0;
            for (int i = 0; i < sense.Length; i++)
            {
                if (sense[i] == 'd' || sense[i] == 'D')
                {
                    count++;
                }
            }
            return count;
        }
        //Capital every first char in a sentence
        public string Capital(string sense) 
        {
            string newmsg = "";
            for (int i = 0; i < sense.Length; i++)
            {
                if (i == 0)
                {
                    newmsg += sense[i].ToString().ToUpper();

                }
                else if (sense[i - 1] == ' ')
                {
                    newmsg += sense[i].ToString().ToUpper();
                }
                else
                {
                    newmsg += sense[i];
                }
            }
            return newmsg;
        }
    }
}
