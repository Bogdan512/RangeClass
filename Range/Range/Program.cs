using System;

namespace RangeOfChars
{
    class Program
    {
        static void Main()
        {
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex));

            IMatch actual = hexSeq.Match("u1234");
            Console.WriteLine(actual.RemainingText());

            Console.Read();
        }
    }
}
