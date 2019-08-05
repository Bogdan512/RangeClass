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
            var whitespace = new Sequance(new Character('\\'), new Any("bnrt"));
            var wsSingle = new Choice(
                        whitespace,
                        new Character('\u0020'),
                        new Character('\u000D'),
                        new Character('\u000A'),
                        new Character('\u0009'));
            var ws = new Optional(new Many(wsSingle));
            var opendBracket = new Character('[');
            var closedBracket = new Character(']');
            var array = new Sequance(ws, opendBracket, ws, closedBracket, ws);
            var value = new Choice(array, str, number, isTrue, isFalse, isNull);
            this.patern = value;
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
