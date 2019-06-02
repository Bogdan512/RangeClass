using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    interface IPattern
    {
        bool Match(string text);
    }
}
