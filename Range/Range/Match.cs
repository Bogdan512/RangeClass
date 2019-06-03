using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    class Match : IMatch
    {

        public bool Succes()
        {
            return true;
        }

        public string RemainingText()
        {
            return "RemainingText";
        }
    }
}
