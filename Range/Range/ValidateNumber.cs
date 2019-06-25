using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfChars
{
    public class ValidateNumber : IPattern
    {
        public IMatch Match(string text)
        {
            bool result = true;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '-':
                        if (i == 0 || text[i - 1] == 'E')
                        {
                            continue;
                        }

                        return new Match(false, text);
                    case '+':
                        if (text[i] == 'e' || text[i - 1] == 'E' && text[i + 1] - 48 >= 1 && text[i + 1] - 48 <= 9)
                        {
                            continue;
                        }

                        return new Match(false, text);
                    case '.':
                        if (i == 0 || i == text.Length - 1)
                        {
                            return new Match(false, text);
                        }

                        if (text[i - 1] - 48 >= 0 && text[i - 1] - 48 <= 9 && text[i + 1] - 48 >= 0 && text[i + 1] - 48 <= 9)
                        {
                            continue;
                        }

                        return new Match(false, text);
                    case 'e':
                        {
                            if (i == text.Length - 1)
                            {
                                return new Match(false, text);
                            }
                            if ((text[i - 1] - 48 >= 0 && text[i - 1] - 48 <= 9) && text[i + 1] - 48 >= 0 && text[i + 1] - 48 <= 9
                                || text[i + 1] == '+' && (text[i + 2] - 48 >= 0 && text[i + 2] - 48 <= 9)
                                || text[i + 1] == '-' && (text[i + 2] - 48 >= 0 && text[i + 2] - 48 <= 9))
                            {
                                continue;
                            }

                            return new Match(false, text);
                        }

                    case 'E':
                        {
                            if (i == text.Length - 1)
                            {
                                return new Match(false, text);
                            }
                            if ((text[i - 1] - 48 >= 0 && text[i - 1] - 48 <= 9) && text[i + 1] - 48 >= 0 && text[i + 1] - 48 <= 9
                                || text[i + 1] == '+' && (text[i + 2] - 48 >= 0 && text[i + 2] - 48 <= 9)
                                || text[i + 1] == '-' && (text[i + 2] - 48 >= 0 && text[i + 2] - 48 <= 9))
                            {
                                continue;
                            }
                            return new Match(false, text);
                        }

                    case '0':
                        {
                            if (i == 0 && text[i + 1] != '.' && text[i + 2] - 48 >= 0 && text[i + 2] - 48 <= 9
                                || i == 2 && text[i - 1] != '.' && text[i - 2] - 48 >= 0 && text[i - 2] - 48 <= 9
                                || i == 1 )
                            {
                                return new Match(false, text);
                            }
                            continue;
                        }
                    default:
                        if (text[i] - 48 >= 1 && text[i] - 48 <= 9)
                        {
                            continue;
                        }
                        else
                        {
                            return new Match(false, text);
                        }
                }
            }

            return new Match(true, string.Empty);
        }
    }
}
