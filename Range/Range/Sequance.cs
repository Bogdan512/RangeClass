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
            foreach (var pattern in patterns)
            {
                IMatch returnPattern = pattern.Match(text);
                if (returnPattern.Succes())
                {
                    text = text.Substring(1);
                }

                if (!returnPattern.Succes() || text == "" )
                {
                    return new Match(false, text);
                }

                if (text == null)
                {
                    return new Match(false, null);
                }
            }
            return new Match(true, text);
        }
    }
}
