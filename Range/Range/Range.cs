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
            Console.WriteLine("Debug1" + text + " " + start + " " + end);
            if (String.IsNullOrEmpty(text) || text[0] < start || text[0] > end)
            {
                Console.WriteLine("Debug 2 ");
                return new Match(false, text);
            }
            Console.WriteLine("Debug 3 ");
            return new Match(true, text.Substring(1));
        }
    }
}
