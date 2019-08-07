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
            var ws = new Many(new Any(" \n\r\t"));
            var opendBracket = new Character('[');
            var closedBracket = new Character(']');
            var comma = new Character(',');
            var array = new Sequance(ws, opendBracket, ws, closedBracket, ws);
            var value = new Choice(array, str, number, isTrue, isFalse, isNull);
            var element = new Sequance(ws, value, ws);
            var elements = new Choice(new Sequance(element, comma, new Many(element)), element);
            var arrayComplete = new Choice(array, new Sequance(opendBracket, elements, closedBracket));
            this.patern = arrayComplete;

        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
