using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var minus = new Optional(new Character('-'));
            var plus = new Optional(new Character('+'));
            var dot = new Character('.');
            var zeroChar = new Character('0');
            var digit = new Range('0', '9');
            var digits = new Many(digit);
            var sign = new Choice(new Sequance(minus, plus));
            var bigOrSmall = new Choice(new Character('E'), new Character('e'));
            var natural = new Choice(zeroChar, new Sequance(new Range('1', '9'), digits));
            var integer = new Sequance(minus, natural);
            pattern = new Sequance(integer, new Optional(new Sequance(dot, digits, new Optional(bigOrSmall), new Optional(sign), digits)));
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}