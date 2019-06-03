using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public interface IPattern
    {
        bool Match(string text);
    }
}
