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
            var quotationmark = new Character('"');
            var escapedChars = new Any("\\/\b\f\n\r\t");
            var choice = new Choice(escapedChars, character);
            this.pattern = new Sequance(quotationmark, new Many(choice), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
