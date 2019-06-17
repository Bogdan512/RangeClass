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
            IMatch match = new Match(true, text);
            match = this.pattern.Match(match.RemainingText());
            if (!match.Succes())
            {
                return match;
            }

            while (match.Succes())
            {
                match = this.pattern.Match(match.RemainingText());
            }

            return new Match(true, match.RemainingText());
        }
    }
}
