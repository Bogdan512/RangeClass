﻿using System;
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
            foreach (var pattern in this.patterns)
            {
                IMatch imatch = pattern.Match(text);
                if (imatch.Succes())
                {
                    return new Match(true, text.Substring(1));
                }
            }
            return new Match(false, text);
        }
    }
}
