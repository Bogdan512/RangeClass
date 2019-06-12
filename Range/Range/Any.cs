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
            Character character = new Character(this.accepted[0]);
            return character.Match(text);
        }

    }
}
