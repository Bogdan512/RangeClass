using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class OneOrMore : IPattern
    {
        private readonly Sequance sequance;

        public OneOrMore(IPattern pattern)
        {
             sequance = new Sequance(pattern, new Many(pattern));
        }

        public IMatch Match(string text)
        {
            IMatch match = sequance.Match(text);
            return text == match.RemainingText()
                ? new Match(false, match.RemainingText())
                : new Match(true, match.RemainingText());
        }
    }
}
