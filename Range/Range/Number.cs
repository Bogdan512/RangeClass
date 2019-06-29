using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            pattern = new Sequance(
                    new Optional(new Character('-')),
                    new Range('1', '9'),
                    new Many(new Range('0', '9')));
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}