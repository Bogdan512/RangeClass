using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Many : IPattern
    {
        IPattern pattern;

        public Many(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {

            IMatch match = new Match(true, text);
            while (match.Succes())
            {
                match = this.pattern.Match(match.RemainingText());
            }

            return new Match(true, match.RemainingText());
        }
    }
}
