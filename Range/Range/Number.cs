using System;

namespace RangeOfChars
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;
        private readonly IPattern patternNoZeroFloat;
        //private readonly IPattern patternSignZeroFloats;
        //private readonly IPattern patternFloats;

        public Number()
        {
            var minus = new Optional(new Character('-'));
            var zeroChar = new Character('0');
            var dot = new Character('.');
            var digit = new Range('0', '9');
            var digits = new Many(digit);
            var natural = new Choice(zeroChar, new Sequance(new Range('1', '9'), digits));
            var integer = new Sequance(minus, natural);
            var zeroFloat = new Sequance(minus, zeroChar, dot, digits);
            pattern = new Sequance(integer, new Optional(new Sequance(dot, digits)));


        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}