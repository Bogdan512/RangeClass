using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class OneOrMore : IPattern
    {
        private readonly Many many;

        public OneOrMore(IPattern pattern)
        {
             this.many = new Many(pattern);
        }

        public IMatch Match(string text)
        {
            IMatch match = this.many.Match(text);
            return text == match.RemainingText()
                ? new Match(false, match.RemainingText())
                : new Match(true, match.RemainingText());
        }
    }
}
