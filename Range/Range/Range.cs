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

            if (text.Length == 1)
            {
                text = string.Empty;
                return new Match(true, text);
            }
            else
            {
                return new Match(true, text.Substring(1));
            }
        }
    }
}
