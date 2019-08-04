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
            var value = new Choice(str, number);
            this.patern = value;
        }

        public IMatch Match(string text)
        {
            return patern.Match(text);
        }
    }
}
