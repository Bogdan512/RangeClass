using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;
        private readonly IPattern patternSignNr;
        //private readonly IPattern patternSignZeroFloats;
        //private readonly IPattern patternFloats;

        public Number()
        {
 

            patternSignNr = new Choice(new Sequance(new Optional(new Character('-')), new OneOrMore(new Range('1', '9')), new Many(new Range('0', '9'))));
            pattern = patternSignNr;

        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}