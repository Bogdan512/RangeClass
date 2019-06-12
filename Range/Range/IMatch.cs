using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public interface IMatch
    {
        bool Succes();

        string RemainingText();
    }
}
