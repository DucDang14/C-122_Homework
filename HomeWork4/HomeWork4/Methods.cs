//Written by Duc Anh Dang
//02/14/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HomeWork4
{
    internal class Methods
    {
        //Count words
        public int countWords(string text)
        {
            int count = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        //Flip end char
            
        public string flipEndChars(string text)
        {
            string msg = "";
            if (text.Length < 2)
            {
                return "Incompatible";
            }
            if (text[0] == text[^1])
            {
                return "Two's a pair";
            }

            msg +=  text[^1] + text.Substring(1,text.Length-2) + text[0];
            
            return msg;
        }
        //Is in order or not
        public bool isInOrder(string text)
        {
            char[] chars = text.ToCharArray();
            string newText = "";
            Array.Sort(chars);
            
            foreach (char c in chars) { newText += c; }
            return newText == text;
        }
        //First n vowels of a string
        public string firstNVowels(string text, int n)
        {
            string vowels = "aeiou";
            string msg = "";
            text.ToLower();
            if (n >= text.Length)
            {
                return "invalid";
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    foreach (char ch in vowels)
                    {
                        if (ch == text[i])
                        {
                           msg += ch;
                        }
                        if (msg.Length == n)
                        {
                            return msg; 
                        }
                    }
                }
            }
            return msg;
        }
        //Change every letter to the next letter
        public string move(string text)
        {
            string msg = "";
            for (int i = 0; i < text.Length; i++)
            {
                msg += ((char)(text[i] + 1)).ToString();
            }
            return msg;
        }
    }
}
