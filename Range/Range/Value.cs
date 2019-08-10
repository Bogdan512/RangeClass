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
            var opendCurlyBracket = new Character('{');
            var closedCurlyBracket = new Character('}');
            var comma = new Character(',');
            var colon = new Character(':');
            var value = new Choice(str, number, isTrue, isFalse, isNull);
            var element = new Sequance(ws, value, ws);
            var elements = new List(element, comma);
            var member = new Sequance(ws, str, ws, colon, element);
            var members = new List(member, comma);
            var obj= new Sequance(ws, opendCurlyBracket, ws, members, ws, closedCurlyBracket, ws);
            var array = new Sequance(ws, opendBracket, ws, elements, ws, closedBracket, ws);
            value.Add(array);
            value.Add(obj);
            this.patern = value;
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
