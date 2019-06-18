using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class OneOrMore : IPattern
    {
        private readonly Many many;

        public OneOrMore(IPattern pattern)
        {
             this.many = new Many(pattern);
        }


        public IMatch Match(string text)
        {
            IMatch match = many.Match(text);

            return text == match.RemainingText()
                ? new Match(false, match.RemainingText())
                : new Match(true, match.RemainingText());
        }


        //public IMatch Match(string text)
        //{
        //    IMatch match = new Match(true, text);
        //    match = this.pattern.Match(match.RemainingText());
        //    if (!match.Succes())
        //    {
        //        return match;
        //    }

        //    while (match.Succes())
        //    {
        //        match = this.pattern.Match(match.RemainingText());
        //    }

        //    return new Match(true, match.RemainingText());
        //}
    }
}
