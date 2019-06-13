using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
   public class Any
    {
        readonly string accepted;

        public Any(string accepted)
        {
            this.accepted = accepted;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(false, text);
            }

            int indexOfFirstCharText = accepted.IndexOf(text[0]);

            return indexOfFirstCharText >= 0 ?
               new Match(true, text.Substring(1)) : new Match(false, text);
        }

    }
}
