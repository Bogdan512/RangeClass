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
            var ws = new Many(wsSingle);
            var opendBracket = new Character('[');
            var closedBracket = new Character(']');
            var initArray = new Sequance(opendBracket, ws, closedBracket);
            var initValue = new Choice(initArray, str, number, isTrue, isFalse, isNull);
            var comma = new Character(',');
            var element = new Sequance(ws, initValue, ws);
            var elements = new Choice(element, new List(new Many(element), comma));
            //var elements = new Choice(element, new Sequance(elenebet, comma, new Many(element)));
            var array = new Choice(initArray, elements);
            var value = new Choice(array, str, number, isTrue, isFalse, isNull); ;
            this.patern = value;
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
