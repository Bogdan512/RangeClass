using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Choice : IPattern
    {
        IPattern[] patterns;
        //List<IPattern> patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            foreach (var pattern in this.patterns)
            {
                IMatch match = pattern.Match(text);
                if (match.Succes())
                {

                    return match;
                }
            }

            return new Match();
        }

        public void Add(Choice choice)
        {
           //List<IPattern> value = new List<IPattern>();

            var wsSingle = new Choice(
                        new Character('\u0020'),
                        new Character('\u000D'),
                        new Character('\u000A'),
                        new Character('\u0009'));
            var ws = new Many(wsSingle);
            var openBracket = new Character('[');
            var closeBracket = new Character(']');
        }
    }
}
