﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Text
    {
        string prefix;

        public Text(string prefix)
        {
            this.prefix = prefix;
        }

        public IMatch Match(string text)
        {
            if (this.prefix == string.Empty)
            {
                return text == null
                    ? new Match(false, text)
                    : new Match(true, text);
            }

            if (string.IsNullOrEmpty(text) || text.Length < this.prefix.Length)
            {
                return new Match(false, text);
            }

            string substring = text.Substring(0, this.prefix.Length);

            return substring == this.prefix
                ? new Match(true, text.Substring(this.prefix.Length))
                : new Match(false, text);
        }

    }
}
