using System;
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
            string substring = text.Substring(0, this.prefix.Length);
            return substring == prefix
                ? new Match(true, text.Substring(this.prefix.Length))
                : new Match(false, text);
        }

    }
}
