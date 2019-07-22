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
            var hex = new Choice(
                        new Range('0', '9'),
                        new Range('a', 'f'),
                        new Range('A', 'F'));
            var escaped = new Sequance(
                            new Character('\\'),
                            new Choice(
                                new Any("\"/bfnrt"),
                                new Sequance(
                                    new Character('u'), hex, hex, hex, hex)));
            var character = new Choice(
                                  new Range('\u0020', '\uffff', "\"\\"),
                                  escaped);
            var characters = new Many(character);
            var quotationmark = new Character('"');
            this.pattern = new Sequance(
                              quotationmark,
                              characters,
                              quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
