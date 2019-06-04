using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Character : IPattern 
    {
        readonly char pattern;

        public Character(char pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(false, text);
            }
            if(text[0] == pattern)
            {
                return new Match(true, text.Substring(1));
            }
            return new Match(false, text);
        }
    }
}
