using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class ValidateString : IPattern
    {

        public IMatch Match(string text)
        {
            char quotationmark = '"';
            char reverseSolidus = '\\';
            char backspace = '\b';
            char formfeed = '\f';
            char newLine = '\n';
            char carriageReturn = '\r';
            char horizontalTab = '\t';

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '"':
                        if (i == 0 || text[i - 1] == reverseSolidus || i == text.Length - 1)
                        {
                            continue;
                        }
                        else
                        {
                            return new Match(false, text);
                        }

                    case '\\':
                        if (text[0] == '\\')
                        {
                            return new Match(false, text);
                        }
                        else
                        {
                            if (text[i - 1] == reverseSolidus || text[i + 1] == reverseSolidus
                            || text[i + 1] == quotationmark || text[i + 1] == backspace || text[i + 1] == formfeed
                            || text[i + 1] == newLine || text[i + 1] == carriageReturn || text[i + 1] == horizontalTab)
                            {
                                continue;
                            }
                        }

                        return new Match(true,string.Empty);
                    default:
                        if (text[0] == quotationmark && text[text.Length - 1] == quotationmark)
                        {
                            continue;
                        }
                        else
                        {
                            return new Match(false, text);
                        }

                        continue;
                }
            }

            return new Match(true, string.Empty);
        }

    }
}
