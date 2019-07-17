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
            //var letter = new Range('a', 'z');
            //var number = new Range('0', '9');
            //var letters = new Many(letter);
            //var numbers = new Many(number);
            //var characters = new List(numbers, letters);
            //byte[] c = new byte[0020 - 20];
            //var character = new Range('\u0020', '\u11300');
            var character1 = new Range('\u0020', '\u0021');
            var character = new Range('\u0023', '\u0fff');
            var characters = new Many(character);
            var characters1 = new Many(character1);
            var quotationmark = new Character('"');

            //this.pattern = new Sequance(quotationmark, new Optional(new Sequance(character, characters)), quotationmark);
            this.pattern = new Sequance(quotationmark, new Optional(characters1), new Optional(characters), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
