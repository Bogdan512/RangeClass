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
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }
            string textToLower = text.ToLower();
            if (text[0] >= start && text[0] <= end)
            {
                return true;
            }
            else return false;
        }
    }
}
