using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Sequance : IPattern
    {
        IPattern[] patterns;

        public Sequance(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            string copyOfText = text;
            foreach (var pattern in this.patterns)
            {
                IMatch matchText = pattern.Match(text);
                IMatch matchcopyOfText = pattern.Match(copyOfText);
                if (!matchcopyOfText.Succes())
                {
                    return matchText;
                }

                copyOfText = matchcopyOfText.RemainingText();
                //text = matchText.RemainingText();
            }

            return new Match(true, copyOfText);
        }
    }
}
