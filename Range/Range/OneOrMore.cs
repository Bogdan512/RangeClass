using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class OneOrMore : IPattern
    {
        IPattern pattern;

        public OneOrMore(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            IMatch match = this.pattern.Match(text);
            return new Match(true, match.RemainingText());
        }
    }
}
