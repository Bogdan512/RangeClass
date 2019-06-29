using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number(IPattern pattern)
        {
            this.pattern = new Sequance(pattern, new Many(pattern));
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}