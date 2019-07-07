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
                Console.WriteLine("4 Choice : " + text + " " + pattern.ToString() + " " + match.Succes());
                if (match.Succes())
                {

                    return match;
                }
            }

            return new Match(false, text);
        }
    }
}
