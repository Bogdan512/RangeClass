using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Sequance : IPattern
    {
        IPattern[] patterns;

        public Sequance(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            IMatch match = new Match(true, text);
            foreach (var pattern in patterns)
            {
                match = pattern.Match(match.RemainingText());
                if (!match.Succes())
                {
                    return new Match(false, text);
                }
            }

            return match;
        }
    }
}
