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
            foreach (var pattern in this.patterns)
            {
                IMatch match = pattern.Match(text);
                if (!match.Succes())
                {
                    return match;
                }
                else
                {
                    text = match.RemainingText();
                }

                //if (match.RemainingText() == string.Empty)
                //{
                //    return match;
                //}

                //if (match.Succes())
                //{
                //    text = match.RemainingText();
                //}
            }

            return new Match(true, text);
        }
    }
}
