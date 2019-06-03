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

        public bool Match(string text)
        {
            bool result = false;

            foreach (var pattern in patterns)
            {
                if (pattern.Match(text))
                {
                    return true;
                }
            }
            return result;
        }
    }
}
