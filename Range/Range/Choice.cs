using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Choice : IPattern
    {
        IPattern[] patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            foreach (var pattern in this.patterns)
            {
                IMatch match = pattern.Match(text);
                if (match.Succes())
                {

                    return match;
                }
            }

            return new Match(false, text);
        }

        public void Add(IPattern newPattern)
        {
            Array.Resize(ref this.patterns, this.patterns.Length + 1);
            this.patterns[this.patterns.Length - 1] = newPattern;

        }
    }
}
