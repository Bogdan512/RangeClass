using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class List : IPattern
    {
        IPattern pattern;
        IPattern separator;

        public List(IPattern pattern, IPattern separator)
        {
            this.pattern = pattern;
            this.separator = separator;
        }

        public IMatch Match(string text)
        {

            IMatch patternMatch = this.pattern.Match(text);
            IMatch separatorMatch;
            while (patternMatch.Succes())
            {
                separatorMatch = this.separator.Match(patternMatch.RemainingText());
                if (string.IsNullOrEmpty(separatorMatch.RemainingText()))
                {
                    return patternMatch;
                }

                patternMatch = this.pattern.Match(separatorMatch.RemainingText());
            }

            return new Match(true, patternMatch.RemainingText());
        }
    }
}
