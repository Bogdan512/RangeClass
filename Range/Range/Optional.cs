using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Optional : IPattern
    {
        IPattern pattern;

        public Optional(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            IMatch match = new Match(true, text);
            match = this.pattern.Match(match.RemainingText());

            return new Match(true, match.RemainingText());
        }
    }
}
