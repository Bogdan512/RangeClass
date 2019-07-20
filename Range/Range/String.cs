using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            var character = new Range('\u0020', '\uffff', "\"\\");
            var characters = new Many(character);
            var quotationmark = new Character('"');
            var escapees = new Any("\\/\b\f\n\r\t");
            var escape = new Sequance(new Optional(new Sequance(new Many(escapees))));
            this.pattern = new Sequance(quotationmark, new Optional(characters), new Optional(escape), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
