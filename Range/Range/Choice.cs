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

            foreach (var pattern in patterns)
            {
                IMatch returnPattern = pattern.Match(text);
                if (returnPattern.Succes())
                {
                    return new Match(true,text.Substring(1));
                }
            }
            return new Match(false, text);
        }
    }
}
