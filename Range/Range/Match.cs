using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class Match : IMatch
    {
        bool succes;
        string remainingText;

        public Match(bool succes, string remainingText)
        {
            this.succes = succes;
            this.remainingText = remainingText;
        }

        public bool Succes()
        {
            return succes;
        }

        public string RemainingText()
        {
            return remainingText;
        }
    }
}
