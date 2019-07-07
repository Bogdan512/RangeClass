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
            Console.WriteLine("3 Character : " + text + " " + /*text[0] + text.Substring(1) + " " +*/ pattern.ToString());
            return string.IsNullOrEmpty(text) || text[0] != pattern 
                ? (IMatch) new Match(false, text)
                : new Match(true, text.Substring(1));
        }
    }
}
