using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Sequence : IPattern
    {
        IPattern[] patterns;

        public Sequence(IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            foreach (IPattern pattern in patterns)
            {

            } return new Match(true,text);
        }
    }
}
