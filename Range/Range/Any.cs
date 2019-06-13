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
            IMatch match = new Match(true, text);

            for (int i = 0; i < this.accepted.Length; i++)
            {
                Character character = new Character(this.accepted[i]);
                if (this.accepted[i] == text[0])
                {
                    match = character.Match(match.RemainingText());
                    return match;
                }
            }

            return new Match(false, text);
        }

    }
}
