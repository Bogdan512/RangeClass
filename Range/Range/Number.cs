using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            this.pattern = new ValidateNumber();
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}