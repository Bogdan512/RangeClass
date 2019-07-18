﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            var character = new Range('\u0020', '\u0fff', "\"\\");
            var characters = new Many(character);
            var quotationmark = new Character('"');
            this.pattern = new Sequance(quotationmark, new Optional(characters), quotationmark);
        }

        public IMatch Match(string text)
        {
            return this.pattern.Match(text);
        }
    }
}
