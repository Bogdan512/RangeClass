using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class List : IPattern
    {
        IPattern pattern;
        IPattern separator;

        public List(IPattern pattern, IPattern separator)
        {
            this.pattern = pattern;
            this.separator = separator;
        }

        public IMatch Match(string text)
        {

            IMatch match = pattern.Match(text);
            match = separator.Match(match.RemainingText());
            return match;
        }
    }
}
