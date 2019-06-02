using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Range
    {
        char start;
        char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public bool Match(string text)
        {
            bool result = true;
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }
            string textToLower = text.ToLower();
            foreach (char c in text)
            {
                if (c >= start && c <= end)
                {
                    continue;
                }
                else return false;
            }
            return result;
        }
    }
}
