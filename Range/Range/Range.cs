using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Range : IPattern
    {
        char start;
        char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public IMatch Match(string text)
        {
            if (String.IsNullOrEmpty(text) || text[0] < start || text[0] > end)
            {
                return new Match(false, text);
            }

            return new Match(text[0] >= start && text[0] <= end, text.Substring(1));
        }
    }
}
