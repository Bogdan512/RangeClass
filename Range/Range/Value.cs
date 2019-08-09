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
            var colon = new Character(':');
            var array = new Sequance(ws, opendBracket, ws, closedBracket, ws);
            var value = new Choice(array, str, number, isTrue, isFalse, isNull);
            var element = new Sequance(ws, value, ws);
            var elements = new List(element, comma);
            var member = new Sequance(ws, str, ws, colon, element);
            var members = new List(member,comma);
            var arrayComplete = new Sequance(ws, opendBracket, ws, elements, ws, closedBracket, ws);
            var valueNoObj = new Choice(arrayComplete, str, number, isTrue, isFalse, isNull);
            this.patern = members;
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
