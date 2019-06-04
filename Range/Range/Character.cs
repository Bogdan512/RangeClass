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
            bool result;
            if (string.IsNullOrEmpty(text))
            {
                result = false;
                return new Match(result, text);
            }
            if(text[0] == pattern)
            {
                result = true;
                return new Match(result, text.Substring(1));
            }
            result = false;
            return new Match(result, text);
        }
    }
}
