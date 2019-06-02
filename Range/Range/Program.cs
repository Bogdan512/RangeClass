using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new Range('a', 'f');
            string text = "abcg";
            bool actual = digits.Match(text);
            Console.WriteLine(actual);

            Console.Read();
        }
    }
}
