using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Value : IPattern
    {
        private readonly IPattern patern;

        public Value()
        {
            var str = new String();
            var number = new Number();
            var isTrue = new Text("true");
            var isFalse = new Text("false");
            var isNull = new Text("null");
            var value = new Choice(str, number, isTrue, isFalse, isNull);
            var wsSingle = new Choice(
                        new Character('\u0020'),
                        new Character('\u000D'),
                        new Character('\u000A'),
                        new Character('\u0009'));
            var ws = new Many(wsSingle);
            var opendBracket = new Character('[');
            var closedBracket = new Character(']');
            var emptyArray = new Sequance(opendBracket, ws, closedBracket);
            this.patern = new Choice(value, emptyArray);
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
