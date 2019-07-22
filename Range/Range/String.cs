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
            var escapeChar = new Character('\\');
            var escapedChars = new Any(@"/\b\f\n\r\t");
            var digit = new Range('0', '9');
            var charAF = new Range('A', 'F');
            var charaf = new Range('a', 'f');
            var hexchar = new Choice(digit, charAF, charaf);
            var hex = new Sequance(hexchar, hexchar, hexchar, hexchar);
            var u = new Sequance(escapeChar, new Character('u'), hex);
            var choice = new Choice(escapedChars, character, u);
            this.pattern = new Sequance(quotationmark, new Many(choice), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
