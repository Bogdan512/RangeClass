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
            var minus = new Optional(new Character('-'));
            var zeroChar = new Character('0');
            var punctChar = new Character('.');
            var digit = new Range('0', '9');
            var digits = new Many(digit);
            var natural = new Sequance(new Range('1', '9'), digits);
            var integer = new Sequance(minus, natural);
            var zeroFloat = new Sequance(minus, zeroChar, punctChar, natural);
            var floatNrs = new Sequance(integer, punctChar, digits);
            pattern = new Choice(floatNrs, integer, zeroFloat);

        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}