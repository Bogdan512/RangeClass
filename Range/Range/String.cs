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
            //char quotationmark = '"';
            //char reverseSolidus = '\\';
            //char backspace = '\b';
            //char formfeed = '\f';
            //char newLine = '\n';
            //char carriageReturn = '\r';
            //char horizontalTab = '\t';
            var letter = new Range('a', 'z');
            var letters = new Many(letter);
            var quotationmark = new Character('"');

            this.pattern = new Sequance(quotationmark, new Optional(letters), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
