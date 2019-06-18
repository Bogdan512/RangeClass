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
             this.sequance = new Sequance(pattern, new Many(pattern));
        }

        public IMatch Match(string text)
        {
            return sequance.Match(text);
        }
    }
}
