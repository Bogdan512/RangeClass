using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class List : IPattern
    {

        private readonly Sequance sequance;

        public List(IPattern pattern, IPattern separator)
        {
            this.sequance = new Sequance(pattern, new Many(new Sequance(separator, pattern)));
        }

        public IMatch Match(string text)
        {
            IMatch match = this.sequance.Match(text);
            return new Match(true, match.RemainingText());
        }
    }
}
