using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Range : IPattern
    {
        char start;
        char end;
        string excluded;

        public Range(char start, char end, string excluded = "")
        {
            this.start = start;
            this.end = end;
            this.excluded = excluded;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text) || this.excluded.Contains(text[0]) || text[0] < this.start || text[0] > this.end)
            {
                return new Match(false, text);
            }
            else
            {
                return new Match(true, text.Substring(1));
            }
        }
    }
}
