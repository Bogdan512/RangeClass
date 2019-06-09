using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );

            var hex = new Choice(
                digit,
                new Choice(
                    new Range('a', 'f'),
                    new Range('A', 'F')
                )
            );

            IMatch actual = hex.Match("269");
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
